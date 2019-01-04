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

namespace BlackOpsMasmCipherSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StuffToDo();

        }
        public void StuffToDo()
        {
            //set inputs to GK scrap 2 
            cipherText.Text = "2366981 13 2455638 7833 1969907 17 833 859 0 278775 188055 254 6297303 19 13 51138 1045748 46158 146 3747 349977 13937091 46807 376388 4632 278775 479 3260788 108792 13 57554 191611 407292 13 1774 4632 17028678 51357 833 5086887 167240 185423 1410635 254 4632 10302704 6297303 19 1031361 2470182 14258 13557614 157 4091537 110 4632 1471289 697881 60609 20500575 32 26161 4632 182710 615190 35 76798 8070075 9496840 32 7227253 157 348445 424 7650687 760 5985040 833 859 4526177 60609 3285425 4632 43518 15994367 76798 730617 7 46250 833 159855 146 749939 19 344753 254 156537 99158 33763146 12472 668518 19 76798 8070075 9496840 32";
            clenText.Text = "5 1 5 3 5 1 2 2 1 5 4 2 5 1 1 4 4 3 2 3 4 5 4 4 3 5 2 5 3 1 4 4 4 1 3 3 5 4 2 5 5 4 4 2 3 5 5 1 4 5 3 5 2 5 3 3 5 4 4 5 1 3 3 4 5 1 4 5 5 1 5 2 5 2 5 2 5 2 2 5 4 5 3 4 5 4 4 2 3 2 5 2 5 1 4 2 4 4 5 3 5 1 4 5 5 1";
            ccountText.Text = "106";
        }

        private void Button_Decipher(object sender, RoutedEventArgs e)
        {
            try
            {
                string output = Model.RunDecipher(cipherText.Text, clenText.Text, ccountText.Text);
                OutputText.Text = output;
            }
            catch(Exception)
            {
                Console.WriteLine("You haz error");
                OutputText.Text = "Error in formatting";
            }
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            cipherText.Clear();
            clenText.Clear();
            ccountText.Clear();
            OutputText.Clear();
        }

    }
}
