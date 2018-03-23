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
        CtrlHome home = new CtrlHome();
        CtrlTarjeta tarjeta = new CtrlTarjeta();

        public MainWindow()
            /*
             * Ver si va a funcionar el sistema de hijos / scrollbar
             */
        {

            InitializeComponent();
            //new BDSql();

            GridHijos.Children.Add(home);
            GridHijos.Children.Add(tarjeta);

        }

        #region Botones
        private void Btnhome_Click(object sender, RoutedEventArgs e)
        {
            Set_margin_slider(btnhome);

            GridHijos.Children.Clear();
            GridHijos.Children.Add(home);
        }

        private void Btntarjetas_Click(object sender, RoutedEventArgs e)
        {
            Set_margin_slider(btntarjetas);

            GridHijos.Children.Clear();
            GridHijos.Children.Add(tarjeta);

            MessageBox.Show(GridHijos.Children.Count.ToString());
        }
        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            Set_margin_slider(btnReportes);
            GridHijos.Children.Clear();
        }
        #endregion
        private void Set_margin_slider (Button btn)
        {
            Thickness margin = pnlSlider.Margin;
            margin.Top = btn.Margin.Top;
            pnlSlider.Margin = margin;

        }

 
    }
}
