using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AtelierXNA
{
    public abstract class TuileDiagonal : Tuile
    {
        const int NB_TRIANGLES = 2;
        int Indice { get; set; }
        public TuileDiagonal(Game jeu, int indice, float homothétieInitiale, Vector3 rotationInitiale, Vector3 positionInitiale, Vector2 étendue, float intervalleMAJ)
            : base(jeu, homothétieInitiale, rotationInitiale, positionInitiale, étendue, intervalleMAJ)
        {
            Indice = indice;
        }

        public override void Initialize()
        {
            NbSommets = NB_TRIANGLES + 2;
            PtsSommets = new Vector3[2, 2];
            CréerTableauSommets();
            CréerTableauPoints();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            EffetDeBase = new BasicEffect(GraphicsDevice);
            InitialiserParamètresEffetDeBase();
            base.LoadContent();
        }

        protected override void CréerTableauPoints()
        {
            if (Indice == 0)
            {
                PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y + Delta.Y, Origine.Z);
                PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y + Delta.Y, Origine.Z + Delta.X - 1.5f);
                PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + Delta.X - 1.5f);
            }
            else
            {
                if (Indice == 1)
                {
                    PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                    PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + 25);
                    PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y + Delta.Y, Origine.Z);
                    PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y + Delta.Y, Origine.Z + 25);
                }
                else
                {
                    if (Indice == 2)
                    {
                        PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y + Delta.Y, Origine.Z);
                        PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y + Delta.Y, Origine.Z + 25);
                        PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                        PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + 25);
                    }
                    else
                    {

                        if (Indice == 3)
                        {
                            PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                            PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z - 25);
                            PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y + Delta.Y, Origine.Z);
                            PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y + Delta.Y, Origine.Z - 25);
                        }
                        else
                        {
                            if (Indice == 4)
                            {
                                PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y + Delta.Y, Origine.Z);
                                PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y + Delta.Y, Origine.Z - 25);
                                PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                                PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z - 25);
                            }
                            else
                            {
                                PtsSommets[0, 0] = new Vector3(Origine.X, Origine.Y, Origine.Z + Delta.Y);
                                PtsSommets[1, 0] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z + Delta.Y - 25);
                                PtsSommets[0, 1] = new Vector3(Origine.X, Origine.Y, Origine.Z);
                                PtsSommets[1, 1] = new Vector3(Origine.X + Delta.X, Origine.Y, Origine.Z - 25);
                            }
                        }
                    }
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