using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {

        IProductService _productService;
        ICategoryService _categoryService;
        Product productByID;

        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            comboBox_ProductCategory.Items.AddRange(_categoryService.TGetAll().Select(x => x.CategoryName).ToArray());

            /*
            comboBox_ProductCategory.DataSource =  _categoryService.TGetAll();
            comboBox_ProductCategory.DisplayMember = "CategoryName";
            comboBox_ProductCategory.ValueMember = "CategoryId";
             */

        }

        private void ShowData(List<Product> products)
        {
            dataGridView_Product.DataSource = products;
        }

        private void ShowDataWithObject(List<object> products)
        {
            dataGridView_Product.DataSource = products;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {

            ShowData(_productService.TGetAll());
        }

        private void button_ListProduct2_Click(object sender, EventArgs e)
        {
            //ShowDataWithObject(_productService.TGetAll().ConvertAll<object>(item => (object)item).ToList());
            /*
             var convertedList = new List<object>(_productService.TGetAll());
             ShowDataWithObject(convertedList);
            */

            ShowDataWithObject(_productService.TGetProductsWithCategory());
        }

        private Product GetProductInformation()
        {
            var product = new Product();
            decimal productPrice;
            bool isPriceDone = decimal.TryParse(textBox_ProductPrice.Text, out productPrice);
            int productStock;
            bool isProductStockDone = int.TryParse(textBox_ProductStock.Text, out productStock);
            var categoryName = comboBox_ProductCategory.SelectedItem.ToString();
            var categoryID = _categoryService.TGetAll().Where(x => x.CategoryName == categoryName).FirstOrDefault().CategoryId;
            if (categoryID == -1 || categoryID == null)
            {
                MessageBox.Show("Kategori Seçiminde yanlışlık var.");
            }
            if (isPriceDone && isProductStockDone)
            {
                product.ProductName = textBox_ProductName.Text;
                product.ProductStock = productStock;
                product.ProductPrice = productPrice;
                product.CategoryId = categoryID;
                product.ProductDescription = textBox_ProductDescription.Text;
            }
            else
            {
                MessageBox.Show("Fiyat veya Stock adeti girişinde yanlışlık var.");
                product.ProductName = string.Empty;
            }
            return product;
        }

        private Product GetProductInformationWithID()
        {
            var product = new Product();
            int productID;
            bool isProductIDDone = int.TryParse(textBox_ProductID.Text, out productID);
            if (isProductIDDone)
            {
                product.ProductId = productID;
                decimal productPrice;
                bool isPriceDone = decimal.TryParse(textBox_ProductPrice.Text, out productPrice);
                int productStock;
                bool isProductStockDone = int.TryParse(textBox_ProductStock.Text, out productStock);
                var categoryName = comboBox_ProductCategory.SelectedItem.ToString();
                var categoryID = _categoryService.TGetAll().Where(x => x.CategoryName == categoryName).FirstOrDefault().CategoryId;
                if (categoryID == -1 || categoryID == null)
                {
                    MessageBox.Show("Kategori Seçiminde yanlışlık var.");
                }
                if (isPriceDone && isProductStockDone)
                {
                    product.ProductName = textBox_ProductName.Text;
                    product.ProductStock = productStock;
                    product.ProductPrice = productPrice;
                    product.CategoryId = categoryID;
                    product.ProductDescription = textBox_ProductDescription.Text;
                }
                else
                {
                    MessageBox.Show("Fiyat veya Stock adeti girişinde yanlışlık var.");
                    product.ProductName = string.Empty;
                }
            }
            else
            {
                product.ProductName = string.Empty;
            }
            return product;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            var product = GetProductInformation();
            if (product.ProductName != string.Empty)
            {
                _productService.TInsert(product);
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi!");
            }
            ShowDataWithObject(_productService.TGetProductsWithCategory());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var productID = 0;
            bool isProductIDDone = int.TryParse(textBox_ProductID.Text, out productID);
            if (isProductIDDone)
            {
                var product = _productService.TGetAll().Where(x => x.ProductId == productID).FirstOrDefault();
                _productService.TDelete(product);
                ShowDataWithObject(_productService.TGetProductsWithCategory());
            }
            else
            {
                MessageBox.Show("Ürün silme işlemi tamamlanamadı!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            productByID.ProductName = textBox_ProductName.Text;
            productByID.ProductStock = int.Parse(textBox_ProductStock.Text);
            productByID.ProductPrice = decimal.Parse(textBox_ProductPrice.Text);
            productByID.ProductDescription = textBox_ProductDescription.Text;
            Debug.WriteLine("description : " + textBox_ProductDescription.Text);
            Debug.WriteLine(productByID.ProductDescription);

            var categoryName = comboBox_ProductCategory.SelectedItem.ToString();
            var categoryID = _categoryService.TGetAll().Where(x => x.CategoryName == categoryName).FirstOrDefault().CategoryId;
            if (categoryID == -1 || categoryID == null)
            {
                MessageBox.Show("Kategori Seçiminde yanlışlık var.");
            }
            productByID.CategoryId = categoryID;



            if (productByID.ProductName != string.Empty)
            {                
                _productService.TUpdate(productByID);
            }
            else
            {                
                MessageBox.Show("Ürün güncellenemedi!");
            }
            ShowDataWithObject(_productService.TGetProductsWithCategory());

        }

        private void btn_GetByID_Click(object sender, EventArgs e)
        {
            var productID = 0;
            bool isProductIDDone = int.TryParse(textBox_ProductID.Text, out productID);
            if (isProductIDDone)
            {
                productByID = _productService.TGetById(productID);
                textBox_ProductID.Text = productByID.ProductId.ToString();
                textBox_ProductName.Text = productByID.ProductName.ToString();
                textBox_ProductStock.Text = productByID.ProductStock.ToString();
                textBox_ProductPrice.Text = productByID.ProductPrice.ToString();
                var categoryNameArray = _categoryService.TGetAll().Select(x => x.CategoryName).ToArray();
                int matchIndex = 0;
                for (int i = 0; i < categoryNameArray.Length; i++)
                {
                    if (_categoryService.TGetAll().Where(x => x.CategoryId == productByID.CategoryId).FirstOrDefault().CategoryName == categoryNameArray[i])
                    {
                        matchIndex = i;
                    }
                }
                comboBox_ProductCategory.SelectedIndex = matchIndex;
                textBox_ProductDescription.Text = productByID.ProductDescription.ToString();
            }
            else
            {
            }
        }
    }
}
