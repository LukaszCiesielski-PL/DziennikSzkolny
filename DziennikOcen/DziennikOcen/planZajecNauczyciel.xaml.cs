using Dziennik;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy planZajecNauczyciel.xaml
    /// </summary>
    public partial class planZajecNauczyciel : Page
    {
        public planZajecNauczyciel()
        {
            InitializeComponent();
            wyswietlPlan();
        }

        public void wyswietlPlan()
        {
            using var db = new baza();

            WyswietlPlanN(GetPrzedmiotN(DaneU.nauczycielZal));

        }

        public void WyswietlPlanN(List<AktualnyPrzedmiot> _aktualnyPrzedmiots)
        {
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Poniedziałek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaKlasa((int)(x.IdKlasa))}" };
                Pon.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Wtorek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaKlasa((int)(x.IdKlasa))}" };
                Wt.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Środa"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaKlasa((int)(x.IdKlasa))}" };
                Sr.Children.Add(_label);

            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Czwartek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaKlasa((int)(x.IdKlasa))}" };
                Czw.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Piątek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaKlasa((int)(x.IdKlasa))}" };
                Pt.Children.Add(_label);
            }
        }
        public List<AktualnyPrzedmiot> GetPrzedmiotN(Nauczyciel nauczyciel)
        {
            using var db = new baza();
            List<AktualnyPrzedmiot> przedmiots = new List<AktualnyPrzedmiot>();
            foreach (var x in db.AktualnyPrzedmiots.Where(o => o.IdNauczyciel == nauczyciel.IdNauczyciel))
            {
                przedmiots.Add(x);
            }
            return przedmiots;
        }

        public string IdNaPrzedmiot(int _naPrzedmiot)
        {
            using var db = new baza();
            return db.Przedmiots.Where(o => o.IdPrzedmiot == _naPrzedmiot).First().Nazwa;
        }

        public string IdNaKlasa(int _naPrzedmiot)
        {
            using var db = new baza();
            var klasa = db.Klasas.Where(o => o.IdKlasa == _naPrzedmiot).First();
            return $"{klasa.Nazwa}";
        }
    }

}
