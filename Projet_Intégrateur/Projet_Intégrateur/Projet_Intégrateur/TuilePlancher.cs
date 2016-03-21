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
    public abstract class TuilePlancher : Tuile
      {
        const int NB_TRIANGLES = 2;
        int Indice { get; set; }
        public TuilePlancher(Game jeu, int indice, float homothétieInitiale, Vector3 rotationInitiale, Vector3 positionInitiale, Vector2 étendue, float intervalleMAJ)
            : base(jeu, homothétieInitiale, rotationInitiale, positionInitiale, étendue, intervalleMAJ)
        {
            Indice = indice;
        }

        public override void Initialize()
        {
            NbSommets = NB_TRIANGLES + 2;
            PtsSommets = new Vector3[2, 2];
            base.Initialize();
            InitialiserSommets();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            InitialiserParamètresEffetDeBase();

        }

        protected override void CréerTableauPoints()
        {
            if(Indice == 1)
            {
                PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z + Delta.Y);
                PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + Delta.Y);
                PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z);
            }
            else
            {
                if(Indice == 2)
                {
                    PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z + Delta.Y);
                    PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + Delta.Y + 25);
                    PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                    PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + 25);
                }
                else
                {

                }
            }

        }

        public override void Draw(GameTime gameTime)
        {
            EffetDeBase.World = GetMonde();
            EffetDeBase.View = CaméraJeu.Vue;
            EffetDeBase.Projection = CaméraJeu.Projection;
            foreach (EffectPass passeEffet in EffetDeBase.CurrentTechnique.Passes)
            {
                passeEffet.Apply();
                DessinerTriangleStrip();
            }
            base.Draw(gameTime);
        }
    }
}
