using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acquisti_Libri_Studenti
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] materie = new string[] { "italiano", "storia", "matematica", "latino", "greco", "italiano" };
        private List<Studente> studenti = new List<Studente>();
        private List<Libro> l = new List<Libro>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCaricaStudente_Click(object sender, RoutedEventArgs e)
        {
            if(txtNome.Text == "" ||  txtCognome.Text == "")
            {
                MessageBox.Show("Credenziali non inserite correttamente!");
            }
            else
            {
                Studente s = new Studente(txtNome.Text, txtCognome.Text);
                
                s.Nome = txtNome.Text;
                s.Cognome = txtCognome.Text;

                studenti.Add(s);

                txtNome.Text = "";
                txtCognome.Text = "";
                txtNome.Focus();

                cmbStudente.Items.Clear();

                foreach(Studente studente in studenti)
                {
                    cmbStudente.Items.Add(s.GetDescrizione());
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int indiceStudenti = cmbStudente.SelectedIndex;
            int indiceLibro = cmbLibro.SelectedIndex;

            if(indiceLibro == -1 || indiceStudenti == -1)
            {
                MessageBox.Show("Verifica la selezione per lo studente o per i libri!");
            }
            else
            {
                lboStampa.Items.Add(studenti[indiceStudenti].Presentati() + l[indiceLibro].GetDescrizione());
            }
        }
    }
}
