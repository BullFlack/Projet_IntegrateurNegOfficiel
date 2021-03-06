﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AtelierXNA
{
    public abstract class TuilePlafond : Tuile
    {
        const int NB_TRIANGLES = 2;
        int Indice { get; set; }
        public TuilePlafond(Game jeu, int indice, float homothétieInitiale, Vector3 rotationInitiale, Vector3 positionInitiale, Vector2 étendue, float intervalleMAJ)
            : base(jeu, homothétieInitiale, rotationInitiale, positionInitiale, étendue, intervalleMAJ)
        {
            Indice = indice;
        }

        public override void Initialize()
        {
            NbSommets = NB_TRIANGLES + 2;
            base.Initialize();
            CréerTableauPoints();

        }

        protected override void LoadContent()
        {
            base.LoadContent();
            InitialiserParamètresEffetDeBase();

        }
        protected override void CréerTableauPoints()
        {
            if (Indice == 1)
            {
                PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z);
                PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z + Delta.Y);
                PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + Delta.Y);
            }
            else
            {
                if(Indice ==2)
                {
                    PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                    PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + 25);
                    PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z + Delta.Y);
                    PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + 25 + Delta.Y);
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


