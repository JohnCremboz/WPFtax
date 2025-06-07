using System;
using System.Windows.Controls;

namespace TAX_WPF
{
    public partial class VakI : UserControl
    {
        public event EventHandler NextRequested;

        public VakI()
        {
            InitializeComponent();
        }

        protected virtual void OnNextRequested()
        {
            NextRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}