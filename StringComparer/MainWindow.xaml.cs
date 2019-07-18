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

namespace StringComparer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string InputText1 { get; set; }
        public string InputText2 { get; set; }
        public bool OutputText { get; set; }



        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            InputText1 = boxi1.Text.ToUpper();
            InputText2 = boxi2.Text.ToUpper();


            OutputText = compare(InputText1, InputText2);
            boxvalid.Text = OutputText.ToString();

        }

        public bool compare(string input1,string input2)
        {

            //string reply = "";
            //reply = input1.ToUpper();
            //reply = input2.ToUpper();
            bool compare = false ;

            if(input1 == input2)
            {
                compare = true;
            }
            else
            {
                compare = false;
            }

            return compare;
        }
    }
}
