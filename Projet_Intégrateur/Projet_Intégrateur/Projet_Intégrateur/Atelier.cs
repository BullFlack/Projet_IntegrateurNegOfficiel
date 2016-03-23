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

   public class Atelier : Microsoft.Xna.Framework.Game
   {
      public Jeu LeJeu { get; set; }
      const float INTERVALLE_CALCUL_FPS = 1f;
      const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
      GraphicsDeviceManager PériphériqueGraphique { get; set; }
      SpriteBatch GestionSprites { get; set; }

      RessourcesManager<SpriteFont> GestionnaireDeFonts { get; set; }
      RessourcesManager<Texture2D> GestionnaireDeTextures { get; set; }
      RessourcesManager<Model> GestionnaireDeModèles { get; set; }
      RessourcesManager<Effect> GestionnaireDeShaders { get; set; }
      Caméra CaméraJeu { get; set; }
      Terrain TerrainJeu { get;set;}
      public InputManager GestionInput { get; private set; }

      public Atelier()
      {
         PériphériqueGraphique = new GraphicsDeviceManager(this);
         Content.RootDirectory = "Content";
         PériphériqueGraphique.SynchronizeWithVerticalRetrace = false;
         IsFixedTimeStep = false;
         IsMouseVisible = true;
      }

      protected override void Initialize()
      {
          LeJeu = new Jeu(this);
          const int DIMENSION_TERRAIN = 512;
          Vector2 étenduePlan = new Vector2(DIMENSION_TERRAIN, DIMENSION_TERRAIN);
          Vector2 charpentePlan = new Vector2(4, 3);
          Vector3 positionCaméra = new Vector3(104, 2, 98);
          Vector3 cibleCaméra = new Vector3(0, 0, 0);

          GestionnaireDeFonts = new RessourcesManager<SpriteFont>(this, "Fonts");
          GestionnaireDeTextures = new RessourcesManager<Texture2D>(this, "Textures");
          GestionnaireDeModèles = new RessourcesManager<Model>(this, "Models");
          GestionnaireDeShaders = new RessourcesManager<Effect>(this, "Effects");
          GestionInput = new InputManager(this);
          TerrainJeu = new Terrain(this, 1f, Vector3.Zero, Vector3.Zero, new Vector3(DIMENSION_TERRAIN, 3, DIMENSION_TERRAIN), "LionelEssai4", "TextureEssai2", 3, INTERVALLE_MAJ_STANDARD);
          CaméraJeu = new CaméraFirstPerson(this, positionCaméra, cibleCaméra, Vector3.Up, INTERVALLE_MAJ_STANDARD);
          Components.Add(GestionInput);
          Components.Add(TerrainJeu);
          Components.Add(CaméraJeu);
          CaméraJeu.Enabled = false;
          Components.Add(new Afficheur3D(this));
          Components.Add(new MenuOption(this, "imageFondMenu", new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height)));
          Services.AddService(typeof(Random), new Random());
          Services.AddService(typeof(RessourcesManager<SpriteFont>), GestionnaireDeFonts);
          Services.AddService(typeof(RessourcesManager<Texture2D>), GestionnaireDeTextures);
          Services.AddService(typeof(RessourcesManager<Model>), GestionnaireDeModèles);
          Services.AddService(typeof(RessourcesManager<Effect>), GestionnaireDeShaders);
          Services.AddService(typeof(InputManager), GestionInput);
          Services.AddService(typeof(Terrain), TerrainJeu);
          Services.AddService(typeof(Caméra), CaméraJeu);
          GestionSprites = new SpriteBatch(GraphicsDevice);
          Services.AddService(typeof(SpriteBatch), GestionSprites);
          base.Initialize();
      }

      protected override void Update(GameTime gameTime)
      {
         GérerClavier();
         base.Update(gameTime);
      }

      private void GérerClavier()
      {
         Vector3 cibleCaméra = new Vector3(0, 0, 0);
         Vector3 positionCaméra0 = new Vector3(0, 250, 125);
         Vector3 positionCaméra1 = new Vector3(0, 300, 0F);

         //Vector3 positionCaméra2 = new Vector3(-20, 30, 30);
         Vector3 positionCaméra2 = new Vector3(30, 30, -20);
         Vector3 cibleCaméra2 = new Vector3(-20, 10, -20);

         Vector3 positionCaméra3 = new Vector3(-90, 30, -140);
         Vector3 cibleCaméra3 = new Vector3(-90, 10, -90);

         Vector3 positionCaméra4 = new Vector3(-75, 20, 50);
         Vector3 cibleCaméra4 = new Vector3(-90, 10, 90);

         if (GestionInput.EstEnfoncée(Keys.Escape))
         {
            Exit();
         }
            if (GestionInput.EstNouvelleTouche(Keys.D1) || GestionInput.EstNouvelleTouche(Keys.NumPad1))
            {
               CaméraJeu.Déplacer(positionCaméra0, cibleCaméra, Vector3.Up);
            }
            else
            {
               if (GestionInput.EstNouvelleTouche(Keys.D2) || GestionInput.EstNouvelleTouche(Keys.NumPad2))
               {
                  CaméraJeu.Déplacer(positionCaméra1, cibleCaméra, Vector3.Forward);
               }
               else
               {
                  if (GestionInput.EstNouvelleTouche(Keys.D3) || GestionInput.EstNouvelleTouche(Keys.NumPad3))
                  {
                     CaméraJeu.Déplacer(positionCaméra2, cibleCaméra2, Vector3.Up);
                  }
                  else
                  {
                     if (GestionInput.EstNouvelleTouche(Keys.D4) || GestionInput.EstNouvelleTouche(Keys.NumPad5))
                     {
                        CaméraJeu.Déplacer(positionCaméra3, cibleCaméra3, Vector3.Up);
                     }
                     else
                     {
                        if (GestionInput.EstNouvelleTouche(Keys.D5) || GestionInput.EstNouvelleTouche(Keys.NumPad5))
                        {
                           CaméraJeu.Déplacer(positionCaméra4, cibleCaméra4, Vector3.Up);
                        }
                     }
                  }
               }
            }
         }


      protected override void Draw(GameTime gameTime)
      {
          GraphicsDevice.Clear(Color.White);
          base.Draw(gameTime);
      }
   }
}

