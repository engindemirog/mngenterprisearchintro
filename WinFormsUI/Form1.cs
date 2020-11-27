using Business;
using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.Oracle;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        ProductManager productManager = new ProductManager(new OracleProductDal());
        CategoryManager categoryManager =new CategoryManager(new OracleCategoryDal());

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = productManager.GetAll();
            dataGridView2.DataSource = categoryManager.GetAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productToAdd = new Product {ProductId = Convert.ToInt32(textBox1.Text), ProductName=textBox2.Text };
            var result =  productManager.Add(productToAdd);

            if (result == null)
            {
                MessageBox.Show("Ürün ismi aynı olamaz");
            }
            else
            {
                MessageBox.Show("Eklendi");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productManager.GetAll();

        }
    }
}
