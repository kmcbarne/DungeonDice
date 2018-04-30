using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for NumberUpDown.xaml
    /// </summary>
    public partial class NumberUpDown : UserControl
    {
        private static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register("Max", typeof(int),
            typeof(NumberUpDown), new FrameworkPropertyMetadata(100));

        private static readonly DependencyProperty MinValueProperty = DependencyProperty.Register("Min", typeof(int),
            typeof(NumberUpDown), new FrameworkPropertyMetadata(0));

        int minValue = 0;
        int maxValue = 100;
        int startingValue = 10;

        public NumberUpDown()
        {
            InitializeComponent();
            PART_TextBox.Text = startingValue.ToString();
            this.DataContext = this;
        }

        public int Max
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public int Min
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        private void PART_TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                PART_Up.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                typeof(Button).GetMethod("set_IsPressed", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(PART_Up, new object[] { true });
            }

            if(e.Key == Key.Down)
            {
                PART_Down.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                typeof(Button).GetMethod("set_IsPressed", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(PART_Down, new object[] { true });
            }
        }

        private void PART_TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
                typeof(Button).GetMethod("set_IsPressed", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(PART_Up, new object[] { false });

            if(e.Key == Key.Down)
                typeof(Button).GetMethod("set_IsPressed", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(PART_Down, new object[] { false });
        }

        private void PART_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int number = 0;

            if(PART_TextBox.Text != "")
                if(!int.TryParse(PART_TextBox.Text, out number))
                    PART_TextBox.Text = startingValue.ToString();

            if(number > maxValue)
                PART_TextBox.Text = maxValue.ToString();

            if(number < minValue)
                PART_TextBox.Text = minValue.ToString();

            PART_TextBox.SelectionStart = PART_TextBox.Text.Length;
        }

        private void PART_Up_Click(object sender, RoutedEventArgs e)
        {
            int number;

            if(PART_TextBox.Text != "")
                number = Convert.ToInt32(PART_TextBox.Text);
            else
                number = 0;

            if(number < maxValue)
                PART_TextBox.Text = Convert.ToString(number + 1);
        }

        private void Part_Down_Click(object sender, RoutedEventArgs e)
        {
            int number;

            if(PART_TextBox.Text != "")
                number = Convert.ToInt32(PART_TextBox.Text);
            else
                number = 0;

            if(number > minValue)
                PART_TextBox.Text = Convert.ToString(number - 1);
        }
    }
}
