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

namespace DungeonDiceRoller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void fourCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(fourCount.IsEnabled)
                fourCount.Text = "1";
            else
                fourCount.Text = "0";
        }

        private void sixCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(sixCount.IsEnabled)
                sixCount.Text = "1";
            else
                sixCount.Text = "0";
        }

        private void eightCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(eightCount.IsEnabled)
                eightCount.Text = "1";
            else
                eightCount.Text = "0";
        }

        private void tenCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(tenCount.IsEnabled)
                tenCount.Text = "1";
            else
                tenCount.Text = "0";
        }

        private void twelveCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(twelveCount.IsEnabled)
                twelveCount.Text = "1";
            else
                twelveCount.Text = "0";
        }

        private void twentyCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(twentyCount.IsEnabled)
                twentyCount.Text = "1";
            else
                twentyCount.Text = "0";
        }

        private void percentCount_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(percentCount.IsEnabled)
                percentCount.Text = "1";
            else
                percentCount.Text = "0";
        }

        private void rollDice_Click(object sender, RoutedEventArgs e)
        {
            DiceRoll roll = new DiceRoll();

            string thrownDice = "";
            
            foreach (int die in roll.RollDice(6, 3))
            {
                thrownDice = thrownDice + die.ToString() + "\r\n ";
            }

            resultsDisplay.Text = thrownDice;
        }
    }
}
