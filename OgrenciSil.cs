﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DersHaneOTM
{
    public partial class OgrenciSil : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");

        public OgrenciSil()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from OgrenciKayıt where numara='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.ClearSelection();
            this.ogrenciKayıtTableAdapter.Fill(this.dershaneLoginDataSet.OgrenciKayıt);
            MessageBox.Show("Kayıt Silindi...");
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBoxEdit1.SelectedIndex = 0;
            textEdit5.Text = "";
            comboBoxEdit2.SelectedIndex = 0;
            textEdit6.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            textEdit8.Text = "";
            textEdit9.Text = "";
            textEdit10.Text = "";
            textEdit11.Text = "";

        }

        public void Sil()
        {
           

        }

    
      

        private void OgrenciSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet.OgrenciKayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciKayıtTableAdapter.Fill(this.dershaneLoginDataSet.OgrenciKayıt);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textEdit2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEdit3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxEdit1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textEdit5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxEdit2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textEdit6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textEdit8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textEdit9.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textEdit10.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textEdit11.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
