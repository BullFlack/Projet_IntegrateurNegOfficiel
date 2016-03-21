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
    public class Jeu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
        const int DIMENSION_TERRAIN = 512;

        const int VALEUR = 50;
        public List<BoundingBox> ListeBB { get; private set; }
        public Jeu(Game game)
            : base(game)
        {}

        public override void Initialize()
        {
            Vector2 étenduePlan = new Vector2(DIMENSION_TERRAIN, DIMENSION_TERRAIN);
            Vector2 charpentePlan = new Vector2(4, 3);
            #region LIGNE PARKING


            //LignePArking
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-6, 1, 15), new Vector2(1, 98), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-30, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-26, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-22, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-18, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-18, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-30, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-26, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-22, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-52, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-48, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-44, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-40, 1, 25), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-40, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-52, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-48, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-44, 1, 43), new Vector2(1, 20), Color.Gold, INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(20 + VALEUR, 1, 25 + VALEUR), new Vector2(1, 56), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(35 + VALEUR, 1, 25 + VALEUR), new Vector2(1, 56), Color.Gold, INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 25 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 29 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 33 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 37 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 41 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 45 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 49 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(30 + VALEUR, 1, 53 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 25 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 29 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 33 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 37 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 41 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 45 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 49 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(15 + VALEUR, 1, 53 + VALEUR), new Vector2(20, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-52 + VALEUR, 1, 30 + VALEUR), new Vector2(69, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileColorée(Game, 1f, Vector3.Zero, new Vector3(-52 + VALEUR, 1, 48 + VALEUR), new Vector2(69, 1), Color.Gold, INTERVALLE_MAJ_STANDARD));
            #endregion
            #region CLG
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 0, -16), new Vector2(20, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-16, 0, -48), new Vector2(45, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-6, 0, -41), new Vector2(30, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            #region frenette
            Game.Components.Add(new TuileDiagonalTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 0, -16), new Vector2(50, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -16), new Vector2(50, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 0, -26), new Vector2(50, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -26), new Vector2(50, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 35, -26), new Vector2(50, 20), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéePlafond(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 35, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));


            #region fenetre Frenette

            //Game.Components.Add(new TuileDiagonalTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 20, -16), new Vector2(1, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new TuileDiagonalTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 20, -16), new Vector2(1, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new TuileDiagonalTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(0, 20, -16), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new TuileDiagonalTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(0, 20, -16), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));



            #endregion


            Game.Components.Add(new TuileDiagonalTexturé(Game, 3, 1f, Vector3.Zero, new Vector3(-41, 0, -3.5f), new Vector2(50, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 4, 1f, Vector3.Zero, new Vector3(-41, 0, -3.5f), new Vector2(50, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 3, 1f, Vector3.Zero, new Vector3(-41, 0, -13.5f), new Vector2(50, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 4, 1f, Vector3.Zero, new Vector3(-41, 0, -13.5f), new Vector2(50, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileDiagonalTexturé(Game, 5, 1f, Vector3.Zero, new Vector3(-41, 35, -13.5f), new Vector2(50, 20), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-41, 0, -13.5f), new Vector2(20, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-41, 0, -13.5f), new Vector2(20, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(19, 0, -13.5f), new Vector2(20, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(19, 0, -13.5f), new Vector2(20, 70), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 28, -26), new Vector2(50, 20), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 28, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 21, -26), new Vector2(50, 20), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 21, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 14, -26), new Vector2(50, 20), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 14, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 7, -26), new Vector2(50, 20), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 7, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 1.1f, -26), new Vector2(50, 20), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            //Components.Add(new TuileDiagonalPlafond1Texturé(this, 1f, Vector3.Zero, new Vector3(-6, 28, -26), new Vector2(50, 20), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));



            #endregion




            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 35f, -41), new Vector2(20, 50), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 0, -40), new Vector2(92, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -49), new Vector2(92, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(30, 0, -75), new Vector2(52, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-16, 0, -75), new Vector2(70, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-96, 0, -110), new Vector2(70, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-96, 0, -75), new Vector2(30, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(74, 0, -110), new Vector2(70, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 0, -75), new Vector2(160, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 0, -60), new Vector2(160, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-96, 0, -110), new Vector2(340, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(40, 0, -26), new Vector2(50, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(40, 0, -49), new Vector2(50, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(40, 0, -49), new Vector2(46, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(65, 0, -49), new Vector2(46, 28), "griss", INTERVALLE_MAJ_STANDARD));

            //AJOUT MUR musique corridor
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(40, 14, -49), new Vector2(18, 42), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(40, 14, -49), new Vector2(18, 42), "griss", INTERVALLE_MAJ_STANDARD));




            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 35, -110), new Vector2(340, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 35, -75), new Vector2(160, 30), "MurPavillon", INTERVALLE_MAJ_STANDARD));

            #region AILE MUSIQUE


            #endregion




            #region DUCHARME INTERIEUR

            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 28, -110), new Vector2(340, 70), "Ceramique", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 21, -110), new Vector2(340, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 14, -110), new Vector2(340, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -110), new Vector2(340, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 1.1f, -110), new Vector2(340, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 28, -75), new Vector2(160, 30), "Ceramique", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 21, -75), new Vector2(160, 30), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 14, -75), new Vector2(160, 30), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -75), new Vector2(160, 30), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 1.1f, -75), new Vector2(160, 30), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            #region FENETRE DUCHARME

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-70, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-50, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-30, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-10, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(10, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(30, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50, 31, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-70, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-50, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-30, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-10, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(10, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(30, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50, 31, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-70, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-50, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-30, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-10, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(10, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(30, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50, 24, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-70, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-50, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-30, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-10, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(10, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(30, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50, 24, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            //
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-70, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-50, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-30, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-10, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(10, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(30, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50, 17, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-70, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-50, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-30, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-10, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(10, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(30, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50, 17, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-70, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-50, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-30, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-10, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(10, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(30, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50, 10, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-70, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-50, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-30, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-10, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(10, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(30, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50, 10, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-70, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-50, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-30, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-10, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(10, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(30, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50, 4, -110.1f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-70, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-50, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-30, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-10, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(10, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(30, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50, 4, -109.9f), new Vector2(8, 4), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));



            //Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -49), new Vector2(92, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(30, 0, -75), new Vector2(52, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            //Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-16, 0, -75), new Vector2(70, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));


            #endregion


            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 35, -75), new Vector2(160, 30), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 28, -75), new Vector2(160, 30), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 21, -75), new Vector2(160, 30), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 14, -75), new Vector2(160, 30), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -75), new Vector2(160, 30), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 35, -110), new Vector2(340, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 28, -110), new Vector2(340, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 21, -110), new Vector2(340, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 14, -110), new Vector2(340, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -110), new Vector2(340, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));

            #region CLASSE DUCHARME

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-96, 7, -75), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            //Components.Add(new TuileTexturéeVertical3(this, 1f, Vector3.Zero, new Vector3(4, 7, -75), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -95), new Vector2(340, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-96, 7, -95), new Vector2(340, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 7, -86), new Vector2(160, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-96, 7, -86), new Vector2(160, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-4, 7, -86), new Vector2(155, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-4, 7, -86), new Vector2(155, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));


            //Superieur
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-76, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-76, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-56, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-56, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-36, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-36, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-16, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-16, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(4, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(4, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(24, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(24, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(44, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(44, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(64, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(64, 7, -110), new Vector2(30, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            //Inférieur
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-76, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-76, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-56, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-56, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-36, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-36, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-16, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-16, 7, -86), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(4, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(4, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(24, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(24, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(44, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(44, 7, -86), new Vector2(22, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            //Components.Add(new TuileTexturéeVertical3(this, 1f, Vector3.Zero, new Vector3(64.5f, 7, -110), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            //Components.Add(new TuileTexturéeVertical4(this, 1f, Vector3.Zero, new Vector3(63.5f, 7, -110), new Vector2(52, 56), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));


            #endregion





            #endregion

            #region AILE SAUVÉ + CAFÉ

            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 1.1f, -75), new Vector2(92, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 28, -75), new Vector2(92, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 21, -75), new Vector2(92, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 14, -75), new Vector2(92, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 7, -75), new Vector2(92, 70), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 35, -75), new Vector2(92, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 28, -75), new Vector2(92, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 21, -75), new Vector2(92, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 14, -75), new Vector2(92, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 7, -75), new Vector2(92, 70), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));




            #endregion









            //Plancher et plafond entree principale
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 1.1f, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 7, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 14, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 21, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 28f, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            //Components.Add(new TuileTexturéePlafond(this, 1f, Vector3.Zero, new Vector3(-16, 1.1f, -41), new Vector2(20, 50), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 7, -41), new Vector2(20, 50), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 14, -41), new Vector2(20, 50), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 21, -41), new Vector2(20, 50), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 28f, -41), new Vector2(20, 50), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 35f, -41), new Vector2(20, 50), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));






            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(-16, 35, -75), new Vector2(92, 70), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(30f, 35, -49), new Vector2(22, 18), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(40, 14, -49), new Vector2(50, 46), "griss", INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-16, 0, -16), new Vector2(20, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-16, 0, -48), new Vector2(45, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(-6, 0, -41), new Vector2(30, 70), "beige", INTERVALLE_MAJ_STANDARD));

            //Components.Add(new TuileTexturéePlafond(this, 1f, Vector3.Zero, new Vector3(-16, 35f, -41), new Vector2(20, 50), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -40), new Vector2(92, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-6, 0, -49), new Vector2(92, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(30, 0, -75), new Vector2(52, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-16, 0, -75), new Vector2(70, 70), "beige", INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(-96, 0, -110), new Vector2(70, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(74, 0, -110), new Vector2(70, 70), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-6, 0, -75), new Vector2(160, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(-96, 0, -60), new Vector2(160, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(-96, 0, -110), new Vector2(340, 70), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(40, 0, -26), new Vector2(50, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(40, 0, -49), new Vector2(50, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(40, 0, -49), new Vector2(46, 28), "griss", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(65, 0, -49), new Vector2(46, 28), "griss", INTERVALLE_MAJ_STANDARD));


            // Components.Add(new TuileTexturéePlafond(this, 1f, Vector3.Zero, new Vector3(-96, 35, -110), new Vector2(340, 70), "beige", INTERVALLE_MAJ_STANDARD));
            //Components.Add(new TuileTexturéePlafond(this, 1f, Vector3.Zero, new Vector3(-16, 35, -75), new Vector2(95, 70), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(31.5f, 35, -49), new Vector2(20, 18), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(40, 14, -49), new Vector2(50, 46), "beige", INTERVALLE_MAJ_STANDARD));


            #endregion
            #region PAVILLON ORDINIQUE
            //PAVILLON ORDINIQUE

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 21 + VALEUR), new Vector2(20, 10), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 55 + VALEUR), new Vector2(20, 10), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 21 + VALEUR), new Vector2(68, 10), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(60 + VALEUR, 0, 21 + VALEUR), new Vector2(68, 10), "MurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 5, 21 + VALEUR), new Vector2(20, 68), "ToitPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 0.7f, 25 + VALEUR), new Vector2(3, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 3, 24.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 3, 30.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 3, 36.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 3, 42.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 3, 48.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 1.5f, 30.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 1.5f, 36.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 1.5f, 42.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3((49.99f) + VALEUR, 0.7f, 49.1f + VALEUR), new Vector2(3, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 0.7f, 25 + VALEUR), new Vector2(3, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 3, 24.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 3, 30.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 3, 36.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 3, 42.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 3, 48.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 1.5f, 30.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 1.5f, 36.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 1.5f, 42.8f + VALEUR), new Vector2(4, 2), "FenetrePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3((50.2f) + VALEUR, 0.7f, 49.1f + VALEUR), new Vector2(3, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));




            //PAVILLON ORDINIQUE INTÉRIEUR -MUR-PLAFOND-PLANCHER

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 54.9f + VALEUR), new Vector2(20, 10), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 21.1f + VALEUR), new Vector2(20, 10), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(59.9f + VALEUR, 0, 21 + VALEUR), new Vector2(68, 10), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(50.1f + VALEUR, 0, 21 + VALEUR), new Vector2(68, 10), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0.7f, 21.1f + VALEUR), new Vector2(20, 68), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuilePlancherTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 2.85f, 21.1f + VALEUR), new Vector2(20, 68), "PlancherIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 2.71f, 21.1f + VALEUR), new Vector2(20, 68), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéePlafond(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 4.9f, 21.1f + VALEUR), new Vector2(20, 68), "PlafondPavillon", INTERVALLE_MAJ_STANDARD));



            //Mur cLASSE Pavillon Ordinique 

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 42f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 41.8f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 33.7f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 33.5f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 48 + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 47.99f + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 2.71f, 48 + VALEUR), new Vector2(9, 4.75f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 2.71f, 47.99f + VALEUR), new Vector2(9, 4.75f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 27f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(50 + VALEUR, 0, 26.99f + VALEUR), new Vector2(7, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0, 27f + VALEUR), new Vector2(42f, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.49f + VALEUR, 0, 27f + VALEUR), new Vector2(41.8f, 9.9f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54.5f + VALEUR, 2.71f, 48f + VALEUR), new Vector2(13.7f, 4.75f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(54.49f + VALEUR, 2.71f, 48f + VALEUR), new Vector2(13.7f, 4.75f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            //Café pavillon Ordinique

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 48 + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 47.99f + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 27f + VALEUR), new Vector2(42.1f, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 27f + VALEUR), new Vector2(42.1f, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 27f + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(56.5f + VALEUR, 0, 26.99f + VALEUR), new Vector2(7, 5.1f), "MurIntérieurPavillon", INTERVALLE_MAJ_STANDARD));

            //CasierPavillon

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 2.71f, 32f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 32f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 35f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            //Components.Add(new TuileTexturée(this, 1f, Vector3.Zero, new Vector3(53.5f, 4.21f, 34f), new Vector2(1f, 6f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 0.7f, 32f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 32f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 35f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 0.7f, 38f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 38f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 41f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 2.71f, 38f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 38f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 41f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 0.7f, 44f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 44f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 0.7f, 47f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54f + VALEUR, 2.71f, 44f + VALEUR), new Vector2(6, 3), "casier", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 44f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 1, 1f, Vector3.Zero, new Vector3(53.5f + VALEUR, 2.71f, 47f + VALEUR), new Vector2(1f, 3f), "beige", INTERVALLE_MAJ_STANDARD));



            //PortePavillon
            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 0.7f, 30f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.48f + VALEUR, 0.7f, 30f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 2.71f, 30f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.48f + VALEUR, 2.71f, 30f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 0.7f, 36f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.48f + VALEUR, 0.7f, 36f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 2.71f, 36f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.48f + VALEUR, 2.71f, 36f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 0.7f, 42f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.48f + VALEUR, 0.7f, 42f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(53.51f + VALEUR, 2.71f, 42f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(53.50f + VALEUR, 2.71f, 42f + VALEUR), new Vector2(2, 3), "PortePavillonInterieur", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54.51f + VALEUR, 2.71f, 53f + VALEUR), new Vector2(2.5f, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new TuileTexturéeVertical(Game, 3, 1f, Vector3.Zero, new Vector3(54.48f + VALEUR, 2.71f, 53f + VALEUR), new Vector2(2.5f, 4), "PortePavillon", INTERVALLE_MAJ_STANDARD));


            Game.Components.Add(new TuileTexturéeVertical(Game, 4, 1f, Vector3.Zero, new Vector3(54.515f + VALEUR, 4.3f, 53.5f + VALEUR), new Vector2(0.5f, 0.1f), "P106", INTERVALLE_MAJ_STANDARD));

            //TableauBlanc Pavillon

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 1, 41.98f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 1, 33.5f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 1, 47.8f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 3.21f, 41.98f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 3.21f, 33.5f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(50.75f + VALEUR, 3.21f, 47.8f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));

            Game.Components.Add(new TuileTexturéeVertical(Game, 2, 1f, Vector3.Zero, new Vector3(51.75f + VALEUR, 3.21f, 54.85f + VALEUR), new Vector2(4, 3), "TableauBlanc", INTERVALLE_MAJ_STANDARD));
            //Tableau echelard

            Game.Components.Add(new TuileDiagonalTexturé(Game, 1, 1f, Vector3.Zero, new Vector3(50.2f + VALEUR, 3.38f, 53.85f + VALEUR), new Vector2(3f, 3), "ToileProjecteur", INTERVALLE_MAJ_STANDARD));
            #endregion
            #region Ciel et Terrrain
            //CIEL
            Game.Components.Add(new Terrain(Game, 1f, Vector3.Zero, Vector3.Zero, new Vector3(DIMENSION_TERRAIN, 3, DIMENSION_TERRAIN), "LionelEssai4", "TextureEssai2", 3, INTERVALLE_MAJ_STANDARD));
            ////Components.Add(new Terrain(this, 1f, Vector3.Zero, Vector3.Zero, new Vector3(DIMENSION_TERRAIN/5, 10, DIMENSION_TERRAIN/5), "LionelEssai3", "Texture1Essai", 2, INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, MathHelper.PiOver2, 0), new Vector3(-DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2, 0), étenduePlan, charpentePlan, "CielGauche", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, -MathHelper.PiOver2, 0), new Vector3(DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2, 0), étenduePlan, charpentePlan, "CielDroite", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, Vector3.Zero, new Vector3(0, DIMENSION_TERRAIN / 2, -DIMENSION_TERRAIN / 2), étenduePlan, charpentePlan, "CielAvant", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(0, -MathHelper.Pi, 0), new Vector3(0, DIMENSION_TERRAIN / 2, DIMENSION_TERRAIN / 2), étenduePlan, charpentePlan, "CielArrière", INTERVALLE_MAJ_STANDARD));
            Game.Components.Add(new PlanTexturé(Game, 1f, new Vector3(MathHelper.PiOver2, 0, 0), new Vector3(0, DIMENSION_TERRAIN - 1, 0), étenduePlan, charpentePlan, "CielDessus", INTERVALLE_MAJ_STANDARD));
            #endregion
                     base.Initialize();
        }
        protected override void LoadContent()
        {
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
