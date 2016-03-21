using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace AtelierXNA
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class MenuOption : FenêtreDeControle
    {
        const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
        const int DIMENSION_TERRAIN = 512;
        const int NB_ZONES_DIALOGUE = 3; //Cette constante doit valoir 3 au minimum
        string NomImageFond { get; set; }
        Rectangle RectangleDialogue { get; set; }
        //Texture2D ImageDeFond { get; set; }
        BoutonDeCommande BtnDémarrer { get; set; }
        //BoutonDeCommande BtnPause { get; set; }
        BoutonDeCommande BtnQuitter { get; set; }
        public Jeu LeJeu { get; set; }
        RessourcesManager<Texture2D> GestionnaireDeTextures { get; set; }

        public MenuOption(Game jeu, string nomImageFond, Rectangle rectangleDialogue)
            : base(jeu, nomImageFond,rectangleDialogue)
        {
            RectangleDialogue = rectangleDialogue;
        }

        public override void Initialize()
        {
            LeJeu = new Jeu(Game);
            int hauteurBouton = RectangleDialogue.Height / (NB_ZONES_DIALOGUE + 1);

            Vector2 PositionBouton = new Vector2(RectangleDialogue.X + RectangleDialogue.Width / 2f,
                                                 RectangleDialogue.Y + (NB_ZONES_DIALOGUE - 2) * hauteurBouton);
            BtnDémarrer = new BoutonDeCommande(Game, "Démarrer", "", "BoutonRouge", "BoutonBleu", PositionBouton, true, true, GérerPause);

            PositionBouton = new Vector2(RectangleDialogue.X + RectangleDialogue.Width / 2f,
                                                 RectangleDialogue.Y + (NB_ZONES_DIALOGUE - 1) * hauteurBouton);
            //BtnPause = new BoutonDeCommande(Game, "Pause", "", "BoutonRouge", "BoutonBleu", PositionBouton, true, GérerPause);

            //PositionBouton = new Vector2(RectangleDialogue.X + RectangleDialogue.Width / 2f,
            //                                     RectangleDialogue.Y + NB_ZONES_DIALOGUE * hauteurBouton);
            BtnQuitter = new BoutonDeCommande(Game, "Quitter", "", "BoutonRouge", "BoutonBleu", PositionBouton, true, true, Quitter);

            Game.Components.Add(BtnDémarrer);
            //Game.Components.Add(BtnPause);
            Game.Components.Add(BtnQuitter);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            GestionSprites.Begin();
            base.Draw(gameTime);
            GestionSprites.End();
        }

        public void GérerPause()
        {
            Vector2 étenduePlan = new Vector2(DIMENSION_TERRAIN, DIMENSION_TERRAIN);
            Vector2 charpentePlan = new Vector2(4, 3);
            Game.Components.Remove(BtnDémarrer);
            Game.Components.Remove(BtnQuitter);
            Game.Components.Remove(this);
            foreach (Caméra caméra in Game.Components.Where(x => x is Caméra))
            {
                caméra.Enabled = true;
            }
            //Game.Components.Add(LeJeu);
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(54.49f, 2.71f, 48f), new Vector2(13.7f, 4.75f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new Terrain(Game, 1f, Vector3.Zero, Vector3.Zero, new Vector3(DIMENSION_TERRAIN, 3, DIMENSION_TERRAIN), "LionelEssai4", "TextureEssai2", 3, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, MathHelper.PiOver2, 0), new Vector3(-DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2, 0), étenduePlan, charpentePlan, "CielGauche", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, -MathHelper.PiOver2, 0), new Vector3(DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2, 0), étenduePlan, charpentePlan, "CielDroite", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, Vector3.Zero, new Vector3(0, DIMENSION_TERRAIN / 2, -DIMENSION_TERRAIN / 2), étenduePlan, charpentePlan, "CielAvant", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, -MathHelper.Pi, 0), new Vector3(0, DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2), étenduePlan, charpentePlan, "CielArrière", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(MathHelper.PiOver2, 0, 0), new Vector3(0, DIMENSION_TERRAIN - 1, 0), étenduePlan, charpentePlan, "CielDessus", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new MenuJeu(Game, "imageFondMenu", new Rectangle(0, 0, (Game.Window.ClientBounds.Width / 2), (Game.Window.ClientBounds.Height / 2)), false));
            Game.Components.Add(new ProgramCoordonnees(Game, ".txt", "Coordonnées"));
        }

        public void Quitter()
        {
            Game.Exit();
        }

        public void DésactiverBoutons()
        {
        }
    }
}
