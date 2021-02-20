using Dziennik;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
namespace DziennikOcen
{
    /// <summary>
    /// Strona wyświetla nam wszystkie przedmioty jakie uczeń ma w każdym dniu na podstawie klasy do której należy
    /// </summary>
    public partial class planZajec : Page
    {
        /// <summary>
        /// Wywołanie składników głównego okna 
        /// 
        /// </summary>
        public planZajec()
        {
            InitializeComponent();
            wyswietlPlan();
        }
        /// <summary>
        /// WyświetlPlan - wywołuje funckję pobierającą przedmioty aktualnie zalogowanego ucznia przypisanego do danej klasy
        /// </summary>
        public void wyswietlPlan()
        {
            using var db = new baza();

            WyswietlPlanU(GetPrzedmiotU(DaneU.uczenZal));

        }
        /// <summary>
        /// Tworzy listę przedmiotów zawierającą przedmiot jaki uczeń odbywa w danym dniu wraz z tym kto go prowadzi
        /// </summary>
        /// <param name="_aktualnyPrzedmiots"></param>
        public void WyswietlPlanU(List<AktualnyPrzedmiot> _aktualnyPrzedmiots)
        {

            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Poniedziałek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Pon.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Wtorek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Wt.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Środa"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Sr.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Czwartek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Czw.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Piątek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Pt.Children.Add(_label);
            }
        }
        /// <summary>
        /// Pobiera listę przedmiotów zalogowanego ucznia poprzez porównanie w bazie ID klasy z ID klasy do której uczęszcza uczeń
        /// </summary>
        /// <param name="uczen"></param>
        /// <returns>Zwraca przedmioty jakie ma uczeń</returns>
        public List<AktualnyPrzedmiot> GetPrzedmiotU(Uczen uczen)
        {
            using var db = new baza();
            List<AktualnyPrzedmiot> przedmiots = new List<AktualnyPrzedmiot>();
            foreach (var x in db.AktualnyPrzedmiots.Where(o => o.IdKlasa == uczen.IdKlasa))
            {
                przedmiots.Add(x);
            }
            return przedmiots;
        }

        /// <summary>
        /// Tłumaczy ID nauczyciela na jego imię i nazwisko
        /// </summary>
        /// <param name="_naNauczyciel"></param>
        /// <returns>Zwraca imię i nazwisko nauczyciela</returns>

        public string IdNaNauczyciel(int _naNauczyciel)
        {
            using var db = new baza();
            var naucz = db.Nauczyciels.Where(o => o.IdNauczyciel == _naNauczyciel).First();
            return $"{naucz.Imie} {naucz.Nazwisko}";
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

    }
}
