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

namespace APLICACION_INVENTARIO.UserControls
{
    /// <summary>
    /// Lógica de interacción para AgregarItemsUC.xaml
    /// </summary>
    public partial class AgregarItemsUC : UserControl
    {
        public AgregarItemsUC()
        {
            InitializeComponent();
        }

        Dictionary<int, string> productos = new Dictionary<int, string>();


        private void NombreProducto(object sender, TextChangedEventArgs e)
        {
            string Producto = nombreProducto.Text.ToUpper();

            if (!string.IsNullOrEmpty(Producto))
            {
                MessageBox.Show("Producto Agregado: " + Producto);
            }
            
        }

        private void ID_producto(object sender, TextChangedEventArgs e)
        {

        }
    }
}

