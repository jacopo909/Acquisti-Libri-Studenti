using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquisti_Libri_Studenti
{
    public class Studente
    {
        private static int matricolaSucessiva = 0;
        private int matricola;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            matricola = CalcolaMatricolaSuccessiva();
        }
        
        private static int CalcolaMatricolaSuccessiva()
        {
            return matricolaSucessiva++;
        }

        public string Presentati()
        {
            return $"Studente {Nome} {Cognome} di matricola {matricola}";
        }
        public string GetDescrizione()
        {
            return $" Descrizione: {matricola} {Cognome} {Nome}";
        }

    }
}
