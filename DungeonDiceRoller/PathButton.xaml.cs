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
    /// Interaction logic for PathButton.xaml
    /// </summary>
    public partial class PathButton : UserControl
    {
        private static readonly DependencyProperty ButtonPathProperty = DependencyProperty.Register("Path", typeof(Figure),
            typeof(ImageButton), null);

        private static readonly DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string),
            typeof(ImageButton), new FrameworkPropertyMetadata(""));

        public PathButton()
        {
            InitializeComponent();
            root.DataContext = this;            
        }

        public Figure ButtonPath
        {
            get { return (Figure)GetValue(ButtonPathProperty); }
            set { SetValue(ButtonPathProperty, value); }
        }

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

    }
}
