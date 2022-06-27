using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ageda
{
    public partial class Form1 : Form
    {
        static DataSet2 db;
        
        
        protected static DataSet2 aged
        {
            get
            {
                if (db == null)
                {
                    db = new DataSet2();
                }
                return db;
            }
        }
        public Form1()
        {
            InitializeComponent();
            aged.Ageda.AddAgedaRow(aged.Ageda.NewAgedaRow());
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           bindingSource1.DataSource = aged.Ageda;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   try
            {
                bindingSource1.EndEdit();
                aged.Ageda.AcceptChanges();
                aged.Ageda.WriteXml(string.Format("{0}//data.txt", Application.StartupPath));
                FileTxt();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aged.Ageda.RejectChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    bindingSource1.RemoveAt(item.Index);
                    dataGridView1.CurrentCell = null;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 1;
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", textBox7, label17, "E-mail format is");

            Regexp(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$", textBox8, label18, "(xx/xx/xxxx) Date format is");

            Regexp(@"^\d{10}$", textBox3, label12, "Phone format is");
            

            if (label17.Text == "E-mail format is Valid"
                & label18.Text == "(xx/xx/xxxx) Date format is Valid" &
                label12.Text == "Phone format is Valid")
            {
                flag = 0;
            }

            try
            {
                if (flag == 0 & textBox1.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox9.Text != "")
                {

                    if (bindingSource1.Position + 1 < bindingSource1.Count)
                        bindingSource1.MoveNext();

                    // Otherwise, move back to the first item.
                    else
                        bindingSource1.MoveFirst();

                    // Force the form to repaint.
                    this.Invalidate();
                    aged.Ageda.AddAgedaRow(aged.Ageda.NewAgedaRow());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aged.Ageda.RejectChanges();

            }
            
        }
        private void FileTxt()
        {
           TextWriter writer = new StreamWriter(@"C:\folder\data.txt");
           for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
           {
               for (int j = 0; j < dataGridView1.Columns.Count; j++)
               {
                   writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
               }
               writer.WriteLine("");
               writer.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
           }
           writer.Close();
           MessageBox.Show("Data Exported");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


           // bindingSource1.ResetBindings(t);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                lbl.ForeColor = Color.Green;
                lbl.Text = s + " Valid";
            }
            else
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = s + " InValid";
            }
        }
    }
 }

