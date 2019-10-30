using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class Form1 : Form {
        List<string> titlar = new List<string>();
        public Form1() {
            InitializeComponent();
            lvTable.FullRowSelect = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {

        }

        private void tablePodcasts_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void btnNew_Click(object sender, EventArgs e) {

        }
        
        private void UpdateTextBox() {
            foreach (var test in titlar) {
                var listItem = new ListViewItem(
                    new[] { test }
                );
                lvCategory.Items.Add(listItem);
            }
        }
        private void btnCNew_Click(object sender, EventArgs e) {
            var category = txtCategory.Text;
            if (category == @"^[a - öA - Ö]{ 3,}$") {
                titlar.Add(category);
                txtCategory.Clear();
            } else {
                MessageBox.Show("Titeln kan bara innehålla text!");
                txtCategory.Clear();
            }
            if (string.IsNullOrEmpty(category)) {
                MessageBox.Show("Textfältet är tomt!");
            }
            UpdateTextBox();
        }
    }
}
