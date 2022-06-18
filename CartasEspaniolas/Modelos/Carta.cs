using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolas.Modelos
{
    public class Carta
    {
        public Carta()
        {
            Numero = 0;
            Palo = "";
        }

        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;

        }

        public int Numero;
        public string Palo;

    }
  
    
   
}
