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

namespace ManageProductsApp
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

        ManageProducts products = new ManageProducts();

        private void Window_Loaded(object sender, RoutedEventArgs e) => LoadProducts();

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Product = new Product
                {
                    ProductID = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text
                };
                products.InsertProduct(Product);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Product");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Product = new Product
                {
                    ProductID = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text
                };
                products.UpdateProduct(Product);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Product");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Product = new Product
                {
                    ProductID = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text
                };
                products.DeleteProduct(Product);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Product");
            }
        }

        private void LoadProducts()
        {
            try
            {
                var productList = products.GetProducts();
                lvProducts.ItemsSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Products");
            }
        }

    }
}