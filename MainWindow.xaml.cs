using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            
            // Apply text wrapping to all TextBlocks
            ApplyTextWrapping(this);
        }

        private void ApplyTextWrapping(DependencyObject parent)
        {
            // Get all TextBlocks in the visual tree
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                
                // If the child is a TextBlock, set its TextWrapping property
                if (child is TextBlock textBlock)
                {
                    textBlock.TextWrapping = TextWrapping.Wrap;
                }
                
                // Recursively process child elements
                ApplyTextWrapping(child);
            }
        }
    }
}
