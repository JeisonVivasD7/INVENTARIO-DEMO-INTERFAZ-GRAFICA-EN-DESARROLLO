using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APLICACION_INVENTARIO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CargarUserControl(UserControl control)
        {
            if (CambioMenu.Children.Count > 0 && CambioMenu.Children[0].GetType() == control.GetType())       
                
                {
                return;
                }
            CambioMenu.Children.Clear();
            control.HorizontalAlignment = HorizontalAlignment.Stretch;
            control.VerticalAlignment = VerticalAlignment.Stretch;
            control.Margin = new Thickness(0);    
            CambioMenu.Children.Add(control);

        
        }

        private void AgregarItems_Click(object sender, RoutedEventArgs e)
        {
            CargarUserControl(new UserControls.AgregarItemsUC());
        }

        private void EliminarItems_Click(object sender, RoutedEventArgs e)
        {
            CargarUserControl(new UserControls.EliminarItemUC());
        }

        private void ConsultarItems_Click(object sender, RoutedEventArgs e)
        {
            CargarUserControl(new UserControls.ConsultarItemsUC());
        }

        private void MermaItems_Click(object sender, RoutedEventArgs e)
        {
            CargarUserControl(new UserControls.MermaItemsUC());
        }

        private void RelacionarPrecios_Click(object sender, RoutedEventArgs e)
        {
            CargarUserControl(new UserControls.RelacionarPreciosUC());
        }
    }
}