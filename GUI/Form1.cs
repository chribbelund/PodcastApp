using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class Form1 : Form {
        List<string> titlar = new List<string>();
        public Form1() {
            InitializeComponent();
            lvTable.FullRowSelect = true;
            lvCategory.FullRowSelect = true;
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

        private void AddToListView(String name, String freq, String category) { //Används för att lägga
            string[] row = { name, freq, category };                            //till användare i ListView
            ListViewItem item = new ListViewItem(row);
            lvTable.Items.Add(item);
        }
        private void btnNew_Click(object sender, EventArgs e) {
            AddToListView(txtName.Text, cboxFre.SelectedItem.ToString(), cboxCategory.SelectedItem.ToString());
        }
        
        private void UpdateTextBox() {          //Används för att lägga till ny användare 
            foreach (var test in titlar) {      //i ListView (ej i combobox)
                var listItem = new ListViewItem(
                    new[] { test }
                );
                lvCategory.Items.Add(listItem);
            }
            titlar.Clear();
        }
        private void btnCNew_Click(object sender, EventArgs e) { //Lägger också till kategorin
            string category = txtCategory.Text;                  //I combobox kategorin
            if (category.Length > 3) {
                titlar.Add(category);
                cboxCategory.Items.Add(category);
                txtCategory.Clear();
            } else {
                MessageBox.Show("Kategorin måste vara längre än 3 bokstäver!", "Kategorin", MessageBoxButtons.OK);
                txtCategory.Clear();
            }
            if (string.IsNullOrEmpty(category)) {
                MessageBox.Show("Textfältet är tomt!");
            }
            UpdateTextBox();
        }

        private void btnCRemove_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Vill du ta bort Kategorin?", "Kategorin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = lvCategory.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        if (cboxCategory.Items.Count>0 && !(String.IsNullOrEmpty(cboxCategory.Text))) {
                            ListViewItem itm = lvCategory.SelectedItems[i];
                            lvCategory.Items[itm.Index].Remove();
                            cboxCategory.Items.Remove(cboxCategory.Text);
                            cboxCategory.ResetText();
                        } else {
                            MessageBox.Show("Var vänlig välj samtliga kategorier!", "Kategorin", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Du har inte valt någon kategori");
        }

        private void btnCChange_Click(object sender, EventArgs e)
        {
            var text = txtCategory.Text;
            if (string.IsNullOrEmpty(text)) {
                MessageBox.Show("Textfältet är tomt!");
            } else {
                lvCategory.SelectedItems[0].SubItems[0].Text = text;
                cboxCategory.SelectedItem.Equals(text);
                txtCategory.Clear();
                MessageBox.Show("Du har nu ändrat kategorins namn!", "Kategorin", MessageBoxButtons.OK);
            }
        }

        private void cboxFre_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (lvTable.SelectedItems.Count > 0) {
                var confirmation = MessageBox.Show("Vill du ta bort Kategorin?", "Kategorin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes) {
                    for (int i = lvTable.SelectedItems.Count - 1; i >= 0; i--) {
                        ListViewItem itm = lvTable.SelectedItems[i];
                        lvTable.Items[itm.Index].Remove();
                        txtName.Clear();
                        cboxFre.ResetText();
                        cboxCategory.ResetText();
                    }
                }
            } else
                MessageBox.Show("Du har inte valt någon kategori");
        }
    }
}
