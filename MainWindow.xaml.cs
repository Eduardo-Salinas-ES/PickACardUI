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

namespace PickACardUI
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
        // Button click event handler
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // When the button is clicked, create an array of picked cards which
            // The number of cards comes from the NumberOfCards slider
            string[] pickedCards = CardPicker.PickSomeCards((int)NumberOfCards.Value);
            // listOfCards is the name of our list box, it will clear list before making a new one
            listOfCards.Items.Clear();
            // remake the list for every new cards we just made using cardpicker
            foreach (var card in pickedCards)
            {
                // Adding to the list
                listOfCards.Items.Add(card);
            }
        }
    }
}
