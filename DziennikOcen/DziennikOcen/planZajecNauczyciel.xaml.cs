using Dziennik;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Strona wyświetla nam wszystkie przedmioty jakie nauczyciel ma w każdym dniu 
    /// </summary>
    public partial class planZajecNauczyciel : Page
    {
        /// <summary>
        /// Wywołanie składników głównego okna 
        /// 
        /// </summary>
        public planZajecNauczyciel()
        {
            InitializeComponent();
            wyswietlPlan();
        }
        /// <summary>
        /// WyświetlPlan - wywołuje funckję pobierającą przedmioty aktualnie zalogowanego nauczyciela 
        /// </summary>
        public void wyswietlPlan()
        {
            using var db = new baza();

            WyswietlPlanN(GetPrzedmiotN(DaneU.nauczycielZal));

        }
        /// <summary>
        /// Tworzy listę przedmiotów zawierającą przedmiot jaki nauczyciel prowadzi w danym dniu wraz z klasą z którą ma zajęcia
        /// </summary>
        /// <param name="_aktualnyPrzedmiots"></param>
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
        /// <summary>
        /// Pobiera listę przedmiotów zalogowanego nauczyciela
        /// </summary>
        /// <param name="nauczyciel"></param>
        /// <returns>Zwraca przdmioty które i dal jakiej klasy prowadzi</returns>
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
        /// <summary>
        /// Tłumaczy ID przedmiotu na jego nazwę
        /// </summary>
        /// <param name="_naPrzedmiot"></param>
        /// <returns>Zwraca nazwę przedmiotu</returns>
        public string IdNaPrzedmiot(int _naPrzedmiot)
        {
            using var db = new baza();
            return db.Przedmiots.Where(o => o.IdPrzedmiot == _naPrzedmiot).First().Nazwa;
        }
        /// <summary>
        /// Tłumaczy ID klasy na jej symbol np. 3Bi
        /// </summary>
        /// <param name="_naPrzedmiot"></param>
        /// <returns></returns>
        public string IdNaKlasa(int _naPrzedmiot)
        {
            using var db = new baza();
            var klasa = db.Klasas.Where(o => o.IdKlasa == _naPrzedmiot).First();
            return $"{klasa.Nazwa}";
        }
    }

}
