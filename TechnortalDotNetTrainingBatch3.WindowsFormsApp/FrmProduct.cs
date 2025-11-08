using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB3.ProductMiniProject.Database.AppDbContextModels;

namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            db.TblProducts.Add(new TblProduct
            {
                CreatedDateTime = DateTime.Now,
                DeleteFlag = false,
                Price = Convert.ToDecimal(txtPrice.Text),
                ProductName = txtProductName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text)
            });
            db.SaveChanges();
        }
    }
}
