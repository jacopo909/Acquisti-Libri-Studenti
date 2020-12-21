using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquisti_Libri_Studenti
{
    public class Libro
    {
        private static int codiceIndex = 0;
        private string Index;
        private double prezzo;
        public string Materia { get; set; }

        public Libro(string materia)
        {
            Materia = materia;
            Index = CalcolaIndex();
        }
        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                if (value <= 0)
                {
                    throw new System.Exception("Prezzo inferiore a 0");
                }
                else
                {
                    prezzo = value;
                }
                {
                }

            }
        }
        public double Sconto()
        {
            Prezzo = Prezzo - (Prezzo * 0.2);
            return Prezzo;
        }
        public static string CalcolaIndex()
        {
            codiceIndex++;
            return $"libro" + codiceIndex;
        }
        public string GetDescrizione()
        {
            return $"Libro di {Materia} con codice {Index} e prezzo {Prezzo}";
        }
    }
}
