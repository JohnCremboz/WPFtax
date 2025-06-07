using System.Windows;
using System.Windows.Controls;

namespace TAX_WPF
{
    public partial class MainWindow : Window
    {
        private VakI vakI;
        private TabControl tabControl;

        public MainWindow()
        {
            InitializeComponent();
            vakI = new VakI();
            tabControl = this.FindName("tabControl") as TabControl;
            vakI.NextRequested += (s, e) => tabControl.SelectedIndex++;
        }
    }
}
