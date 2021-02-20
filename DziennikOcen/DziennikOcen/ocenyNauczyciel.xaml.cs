using Dziennik;
using System;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy ocenyNauczyciel.xaml
    /// Klasa ta pozwala nauczycielowi wpisać konkretneu uczniowi daną ocenę wraz z opisami, datą i rodzajem z jakiego przedmiotu ją otrzymał
    /// </summary>
    public partial class ocenyNauczyciel : Page
    {
        public ocenyNauczyciel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int idU = Int32.Parse(this.b.Text);
            string ocena = this.bb.Text;
            int idN = Int32.Parse(this.bbb.Text);
            int idP = Int32.Parse(this.bbbb.Text);
            string opis = this.opis.Text;
            string data = this.data.Text;
            using var db = new baza();



            var nowaOcena = new Ocena
            {

                IdUczen = idU,
                Ocena1 = ocena,
                Opis = opis,
                IdNauczyciel = idN,
                IdPrzedmiot = idP,
                Data = data


            };


            db.Ocenas.Add(nowaOcena);
            db.SaveChanges();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
