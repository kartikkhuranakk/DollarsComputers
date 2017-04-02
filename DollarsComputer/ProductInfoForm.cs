using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * APP NAME - Dollars Computers
 * AUTHOR'S NAME - KARTIK KHURANA
 * STUDENT ID - 200331395
 * DATE - MARCH 31st  , 2017
 * This form tells the user about the product information
 */
namespace DollarsComputer
{
    public partial class ProductInfoForm : Form
    {
        public SelectForm PreviousForm { get; set; }

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();


            orderForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
