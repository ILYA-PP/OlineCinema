using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OlineCinema
{
    class ControlButton
    {
        public Button MaximizedB { get; set; }
        public Button MinimizedB { get; set; }
        public Button CloseB { get; set; }

        public ControlButton()
        {
            MaximizedB.Click += new RoutedEventHandler(MaximizedB_Click);
            MinimizedB.Click += new RoutedEventHandler(MinimizedB_Click);
            CloseB.Click += new RoutedEventHandler(CloseB_Click);
        }

        private void MaximizedB_Click(object sender, EventArgs args)
        {
            
        }

        private void MinimizedB_Click(object sender, EventArgs args)
        {

        }

        private void CloseB_Click(object sender, EventArgs args)
        {

        }
    }
}
