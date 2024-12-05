using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {

        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            // Bu arkadaşı kullanmak için null durumundan kurtarmamız gerek.
            // Bu arkadaşa CategoryManager sınıfından örnekliyoruz çünkü interfaceler sadece referans tutucu olarak çalışıyor.
            // interface'ler örneklenemez!!!
            // CategoryManager yapılandırıcı metoduna ICategoryDal türünde bir nesne istiyor. Bunun içinde miras aldığı EFCategoryDal'ı vereceğiz.
            // Bunu dependency injectiona söylecek olsak 
            // IEntityADIService gördüğün yerde EntityADIManager örnekle
            // IEntityADIDal gördüğün yerde EfEntityADIDal örnekle
            // Kurgulayacaktık.
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
            RefreshListAll();
        }

        private Category GetInformationFromForm() {
            var category = new Category();
            category.CategoryName = textBox_CategoryName.Text;
            bool activeButton = radioButton_CategoryStatusActive.Checked;
            bool passiveButton = radioButton_CategoryStatusPassive.Checked;
            if (activeButton)
            {
                category.CategoryStatus = true;
            }
            else
            {
                category.CategoryStatus = false;
            }
            return category;
        }

        private void RefreshListAll() { 
            var categoriesValues = _categoryService.TGetAll();
            dataGridView_Category.DataSource = categoriesValues;        
        }

        private void ClearFields() { 
           textBox_CategoryID.Text = string.Empty;
            textBox_CategoryName.Text = string.Empty;
            radioButton_CategoryStatusActive.Checked = false;
            radioButton_CategoryStatusPassive.Checked = false;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            RefreshListAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {            
            _categoryService.TInsert(GetInformationFromForm());
            RefreshListAll();
            ClearFields();
            MessageBox.Show("Ekleme başarılı!");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var category = _categoryService.TGetById(int.Parse(textBox_CategoryID.Text));
            _categoryService.TDelete(category);
            RefreshListAll();
            ClearFields();
            MessageBox.Show("Silme başarılı!");
        }

        private void btn_GetByID_Click(object sender, EventArgs e)
        {
            dataGridView_Category.DataSource = new List<Category> { _categoryService.TGetById(int.Parse(textBox_CategoryID.Text)) };            
            ClearFields();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var updatedCategory = _categoryService.TGetById(int.Parse(textBox_CategoryID.Text));
            updatedCategory.CategoryName = textBox_CategoryName.Text;
            bool activeButton = radioButton_CategoryStatusActive.Checked;
            bool passiveButton = radioButton_CategoryStatusPassive.Checked;
            if (activeButton)
            {
                updatedCategory.CategoryStatus = true;
            }
            else
            {
                updatedCategory.CategoryStatus = false;
            }
            _categoryService.TUpdate(updatedCategory);
            RefreshListAll();
            ClearFields();

        }

    }
}
