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

namespace Stringmanipulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string InputText { get; set; }
        public string OutputText { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            InputText = blockInput.Text;

            string operation = Combobox.SelectionBoxItem.ToString();

            if(operation=="Capital")
            {
                OutputText = ConvertToCapital(InputText);
                blockoutput.Text = OutputText;
            }

            else if(operation=="Small")
            {
                OutputText = ConvertToSmall(InputText);
                blockoutput.Text = OutputText;
            }

            else if(operation=="Reverse")
            {
                OutputText = ConvertToReverse(InputText);
                blockoutput.Text = OutputText;
            }

            else if(operation=="Append")
            {
                OutputText = ConvertToAppend(InputText);
                blockoutput.Text = OutputText;
            }
            else if(operation=="TrimEnd")
            {
                OutputText = ConvertToTrimEnd(InputText);
                blockoutput.Text = OutputText;
            }

        }

        #region Method

        public string ConvertToCapital(string input)
        {
            string reply = "";
            reply = input.ToUpper();
            return reply;
        }

        public string ConvertToSmall(string input)
        {
            string reply = "";
            reply = input.ToLower();
            return reply;
        }

        public string ConvertToReverse(string input)
        {
            string myString = "";
            char[] charArray = input.ToCharArray();

            Array.Reverse(charArray);
            return new string(charArray);
    
        }

        public string ConvertToAppend(string input)
        {
            string reply = "";
            reply = input;
            reply += "a";
            return reply;
        }

        public string ConvertToTrimEnd(string input)
        {
            string reply = "";
            reply = input;
            return reply.TrimEnd(reply[reply.Length - 1]);
        }
        #endregion
    }
}
