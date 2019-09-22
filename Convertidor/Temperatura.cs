using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    public class Temperatura
    {
        private double centigrados;

        public void setGrados(double valor)
        {
            this.centigrados = valor;

        }

        public double getCentigrados()
        {
            return this.centigrados;
        }

        public double convertir()
        {
            return ((this.getCentigrados() * 9 / 5) + 32);

               // formula = (°C × 9 / 5) + 32
        }
        
    }
}
