using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Entity : Form
    {
        public Entity()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Entity_Load(object sender, EventArgs e)
        {
           LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            });
            LoadProducts();
            MessageBox.Show("Added!");
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
            });
            LoadProducts();
            MessageBox.Show("Update!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            });
            LoadProducts();
            MessageBox.Show("Deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Type t = typeof(String);
       
            var txt = tbxSearch.Text;
            t = txt.GetType();

            if (!decimal.TryParse(tbxSearch.Text, out _))
            {
                SearchProducts(tbxSearch.Text);
            }
            else
            {
                SearchProductsWithPrice(Convert.ToDecimal(tbxSearch.Text));
            }

        }

        private void SearchProducts(string key)
        {
            dgwProducts.DataSource = _productDal.GetByName(key);
            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();

        }

        private void SearchProductsWithPrice(decimal key)
        {
            dgwProducts.DataSource = _productDal.GetByUnitPrice(key);
        }
    }
}
