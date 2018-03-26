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
using System.Windows.Media.Animation;
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
        {

            InitializeComponent();
            //new BDSql();

            PutChildren(btnhome, home);
            //MessageBox.Show();
        }

        #region Botones
        private void Btnhome_Click(object sender, RoutedEventArgs e)
        {
            PutChildren(btnhome,home);
        }

        private void Btntarjetas_Click(object sender, RoutedEventArgs e)
        {
            PutChildren(btntarjetas, tarjeta);

        }
        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            //PutChildren(btnReportes);
        }
        #endregion
        private void PutChildren (Button btn, UserControl uctrl)
        {
            /*
             * Coloca el hijo en el lugar, toma el tamanio del wrap contenedor, y pinta el boton actualmente activo
             */
            Thickness margin = pnlSlider.Margin;
            margin.Top = btn.Margin.Top;
            pnlSlider.Margin = margin;
            WrapHijos.Children.Clear();
            WrapHijos.Children.Add(uctrl);
            WrapHijos.Children[0].SetValue(WidthProperty, WrapHijos.ActualWidth);
        }
        private void WrapHijos_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WrapHijos.Children[0].SetValue(WidthProperty, WrapHijos.ActualWidth);
        }

    }
}
