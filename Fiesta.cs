using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimofísmoWF
{
    partial class Fiesta
    {
        protected int numPersonas = 0;
        protected double costeDecoracion = 0.0;
        protected bool decoracionLujo = false;
        protected const double costeFijoPersona = 25;

        public int NumPersonas
        {
            get { return numPersonas; }
            set { numPersonas = value; }
        }

        public double CosteDecoracion
        {
            get { return costeDecoracion; }
            set { costeDecoracion = value; }
        }

        public bool DecoracionLujo
        {
            get { return decoracionLujo; }
            set { decoracionLujo = value; }
        }

        public double CosteFijoPersona
        {
            get { return costeFijoPersona; }
        }

        public Fiesta() { }

        public virtual void CalcularCosteDecoracion()
        {
            if (DecoracionLujo) { CosteDecoracion = (NumPersonas * 15) + 50; }
            else { CosteDecoracion = (NumPersonas * 7.50) + 30; }
        }

        public virtual double CalcularCoste()
        {
            double coste = 0.0;
            return coste;
        }
    }

}
