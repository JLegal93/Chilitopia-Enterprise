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

namespace Chilitopia_Enterprise
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Set_margin_slider(btnhome);
        }

        private void Btnhome_Click(object sender, RoutedEventArgs e)
        {
            Set_margin_slider(btnhome);
        }

        private void Btntarjetas_Click(object sender, RoutedEventArgs e)
        {
            Set_margin_slider(btntarjetas);

        }
        private void Set_margin_slider (Button btn)
        {
            Thickness margin = pnlSlider.Margin;
            margin.Top = btn.Margin.Top;
            pnlSlider.Margin = margin;

        }
    }
}
