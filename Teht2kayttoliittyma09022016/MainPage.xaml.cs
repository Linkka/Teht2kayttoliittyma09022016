using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht2kayttoliittyma09022016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // bring from a textbox located on MainPage.xaml
            string euro1 = eurkTextBox.Text;
            // bring from a textbox located on MainPage.xaml
            string markka1 = markTextBox.Text;
            double result1;
            double result2;
            try
            {
                // euro1 from a string to double
                result1 = Convert.ToDouble(euro1);
                // multiply
                result2 = result1 * 5.97;
                // back to a string
                martTextBlock.Text = result2.ToString();
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string markka1 = markTextBox.Text;
            double result1;
            double result2;
            try
            {
                result1 = Convert.ToDouble(markka1);
                result2 = result1 / 5.97;
                eurtTextBlock.Text = result2.ToString();
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }
    }
}
