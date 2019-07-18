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

namespace ListbyRadiobutton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listbox1.ItemsSource = SocialMedia;
            //listbox1.ItemsSource = News;
            //listbox1.ItemsSource = Sports;
            //listbox1.ItemsSource = Email;

        }
        List<string> SocialMedia = new List<string>() { "Facebook", "Twitter", "Instagram", "Whatsapp", "Hike" };
        List<string> News = new List<string>() { "VTV", "Aaj Tak", "TV9", "ZEE NEWS", "NDTV" };
        List<string> Sports = new List<string>() { "Cricket", "Cycling", "Chess", "Boxing", "Bowling" };
        List<string> Email = new List<string>() { "Gmail", "Yahoo", "Outlook", "Hotmail", "Reddifmail" };

        
        private void Radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}
   
