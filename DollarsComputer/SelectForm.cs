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
 * This form gives user authority to select the different kinds of versions of computers
 */
namespace DollarsComputer
{
    public partial class SelectForm : Form
    {
        public StartForm PreviousForm;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductInfoForm productForm = new ProductInfoForm();


            productForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
