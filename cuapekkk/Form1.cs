using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace cuapekkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int buatan;
        int produk;
        int tambah;
        string productcek;
        string category;
        string pass;
        string pilih;
        
        int count = 5;
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        List<string> id = new List<string>();
        List<string> barang = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = false;
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dataGridView_product.DataSource = dtProdukSimpan;
            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
 
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dataGridView_Category.DataSource = dtCategory;
            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            id.Add("C1");
            id.Add("C2");
            id.Add("C3");
            id.Add("C4");
            id.Add("C5");
            barang.Add("Jas");
            barang.Add("T-Shirt");
            barang.Add("Rok");
            barang.Add("Celana");
            barang.Add("Cawat");


            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");
            foreach (string a in barang)
            {
                comboBox_Filter.Items.Add(a);
                comboBox_Category.Items.Add(a);
            }
            button_AddCategory.BackColor = Color.Bisque;
            button_AddCategory.ForeColor = Color.OrangeRed;
            button_RemoveCatagory.BackColor = Color.DarkViolet;
            button_RemoveCatagory.ForeColor = Color.Goldenrod;
            button_AddProduct.BackColor = Color.SaddleBrown;
            button_AddProduct.ForeColor = Color.CadetBlue;
            button_RemoveProduct.BackColor = Color.Gray;
            button_RemoveProduct.ForeColor = Color.HotPink;
            button_EditProduct.BackColor = Color.LightBlue;
            button_EditProduct.ForeColor = Color.Coral;
            this.BackColor = Color.Cornsilk;
            
        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            int cek = 1;
            bool benar = false;
            if (textBox_NamaCategory.Text == "")
            {
                MessageBox.Show("isi dulu ya namanya");
            }
            else
            {
                foreach (string a in barang)
                {
                    if (textBox_NamaCategory.Text.ToLower() == a.ToLower())
                    {
                        MessageBox.Show("nama category udah ada");
                        benar = false;
                        break;
                    }
                    else
                    {
                        benar = true;
                        cek++;
                    }
                }
                if (benar == true)
                {
                    
                    id.Add("C" + cek);
                    barang.Add(textBox_NamaCategory.Text);
                    dtCategory.Rows.Add("C"+cek, textBox_NamaCategory.Text);
                    comboBox_Category.Items.Add(textBox_NamaCategory.Text);
                    comboBox_Filter.Items.Add(textBox_NamaCategory.Text);
                }
            }
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            if ((textBox_namaproduct.Text == "") || (textBox_Harga.Text == "") || (comboBox_Category.Text == "") || (textBox_Stock.Text == ""))
            {
                MessageBox.Show("isi yang lengkap");
            }
            else if (textBox_Stock.Text == 0.ToString())
            {
                MessageBox.Show("stock ga boleh kosong");
            }
            else
            {
                for(int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (textBox_namaproduct.Text[0].ToString().ToUpper() == dtProdukSimpan.Rows[i][0].ToString()[0].ToString()) ;
                    {
                        produk = Convert.ToInt32(dtProdukSimpan.Rows[i][0].ToString().Substring(1));
                        if (produk >= tambah)
                        {
                            tambah = produk;
                        }
                    }
                }
                tambah = tambah + 1;
                productcek= textBox_namaproduct.Text[0].ToString().ToUpper();
                for (int i = tambah.ToString().Length; i < 3; i++)
                {
                    productcek += "0";
                }
                productcek += Convert.ToString(tambah);
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == comboBox_Category.SelectedItem.ToString())
                    {
                        category = dtCategory.Rows[i][0].ToString();
                    }
                }
                dtProdukSimpan.Rows.Add(productcek, textBox_namaproduct.Text, textBox_Harga.Text, textBox_Stock.Text, category);
                textBox_namaproduct.Clear();
                textBox_Harga.Clear();
                textBox_Stock.Clear();
            }
        }

        private void button_RemoveCatagory_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Items.Remove(dataGridView_Category.SelectedCells[1].Value.ToString());
            comboBox_Category.Items.Remove(dataGridView_Category.SelectedCells[1].Value.ToString());

            for (int i = dtProdukSimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProdukSimpan.Rows[i][4].ToString() == dataGridView_Category.SelectedCells[0].Value.ToString())
                {
                    dtProdukSimpan.Rows.RemoveAt(i);
                }
            }
            if (dataGridView_Category.SelectedCells[0].Value.ToString().Substring(1) == count.ToString())
            {
                count--;
            }
            foreach (DataRow b in dtCategory.Rows)
            {
                if (b[1].ToString() == pass)
                {
                    dtCategory.Rows.Remove(b);
                    break;
                }
            }
        }
    

       
        
        


        private void button_Filter_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProdukTampil.Rows.Clear();
            dataGridView_product.DataSource = dtProdukTampil;

            for (int i = 0; i < barang.Count; i++)
            {
                if (comboBox_Filter.SelectedItem == dtCategory.Rows[i][1])
                {
                    for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
                    {
                        if (dtCategory.Rows[i][0] == dtProdukSimpan.Rows[j][4])
                        {
                            dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[j][0], dtProdukSimpan.Rows[j][1], dtProdukSimpan.Rows[j][2], dtProdukSimpan.Rows[j][3], dtProdukSimpan.Rows[j][4]);
                        }
                    }
                }
            }
           
        }

        private void textBox_Harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       

        private void button_EditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox_Stock.Text == "0")
                {
                    dtProdukSimpan.Rows.RemoveAt(dataGridView_product.CurrentCell.RowIndex);
                    textBox_Harga.Text = "";
                    textBox_Stock.Text = "";
                    textBox_namaproduct.Text = "";
                    comboBox_Category.Text = null;
                }
                else
                {
                    dtProdukSimpan.Rows[buatan][1] = textBox_namaproduct.Text;
                    dtProdukSimpan.Rows[buatan][3] = textBox_Stock.Text;
                    dtProdukSimpan.Rows[buatan][2] = textBox_Harga.Text;

                    for (int i = 0; i < barang.Count; i++)
                    {

                        if (comboBox_Category.SelectedItem == barang[i])
                        {


                            dtProdukSimpan.Rows[buatan][4] = id[i].ToString();

                        }
                    }
                    dataGridView_product.DataSource = dtProdukSimpan;
                }


            }
            textBox_Harga.Text = "";
            textBox_Stock.Text = "";
            textBox_namaproduct.Text = "";
            comboBox_Category.Text = null;
        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isi = false;

            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (pilih == dtProdukSimpan.Rows[i][0].ToString())
                {
                    dtProdukSimpan.Rows[i][2] = textBox_namaproduct.Text;
                    dtProdukSimpan.Rows[i][3] = textBox_Harga.Text;
                    dtProdukSimpan.Rows[i][4] = textBox_Stock.Text;
                    string saved_Data = "";
                    for (int k = 0; k < dtCategory.Rows.Count; k++)
                    {
                        if (dtCategory.Rows[k][1].ToString() == comboBox_Filter.SelectedItem.ToString())
                        {
                            saved_Data = dtCategory.Rows[k][0].ToString();
                        }
                    }
                    dtProdukSimpan.Rows[i][4] = saved_Data;
                }
            }
            dtProdukTampil.Clear();
            for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
            {
                dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[j][0].ToString(), dtProdukSimpan.Rows[j][1].ToString(), dtProdukSimpan.Rows[j][2].ToString(), dtProdukSimpan.Rows[j][3].ToString(), dtProdukSimpan.Rows[j][4].ToString());
            }
            dataGridView_product.DataSource = dtProdukTampil;
        }

        private void dataGridView_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_product.DataSource == dtProdukSimpan)
            {
                buatan = dataGridView_product.SelectedCells[0].RowIndex;

                textBox_namaproduct.Text = dtProdukSimpan.Rows[buatan][1].ToString();
                textBox_Stock.Text = dtProdukSimpan.Rows[buatan][3].ToString();
                textBox_Harga.Text = dtProdukSimpan.Rows[buatan][2].ToString();
                for (int i = 0; i < barang.Count; i++)
                {

                    if (dtProdukSimpan.Rows[buatan][4].ToString() == id[i])
                    {
                        comboBox_Category.Text = barang[i];
                    }
                }
            }
            else
            {
                buatan = dataGridView_product.SelectedCells[0].RowIndex;

                textBox_namaproduct.Text = dtProdukTampil.Rows[buatan][1].ToString();
                textBox_Stock.Text = dtProdukTampil.Rows[buatan][3].ToString();
                textBox_Harga.Text = dtProdukTampil.Rows[buatan][2].ToString();
                for (int i = 0; i < barang.Count; i++)
                {

                    if (dtProdukTampil.Rows[buatan][4].ToString() == id[i])
                    {
                        comboBox_Category.Text = barang[i];
                    }
                }

            }
        }

        private void button_RemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtProdukSimpan.Rows.RemoveAt(dataGridView_product.CurrentCell.RowIndex);
            }

        }

        private void button_All_Click(object sender, EventArgs e)
        {
            dataGridView_product.DataSource = dtProdukSimpan;
        }

        private void dataGridView_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void dataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            pass = dataGridView_Category.SelectedCells[1].Value.ToString();
            textBox_NamaCategory.Text = dtCategory.Rows[buatan][1].ToString();
        }
    }
}