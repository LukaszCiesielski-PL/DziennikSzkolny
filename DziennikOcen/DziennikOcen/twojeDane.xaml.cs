using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Dziennik;
using Microsoft.EntityFrameworkCore;
using DziennikOcen;
using System.Linq;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy twojeDane.xaml
    /// </summary>
    public partial class twojeDane : Page
    {
        public twojeDane(Uczen _uczen)
        {
            InitializeComponent();
            wyswietlDane(_uczen);
        }

        public void wyswietlDane(Uczen _uczen)
        {
            using var db = new baza();
            daneZalogU.Content = _uczen.IdOpiekun;
            


        }
    }
}
