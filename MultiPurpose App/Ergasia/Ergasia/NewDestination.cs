using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia{
    public partial class NewDestination : Form{
        public NewDestination(){
            InitializeComponent();

            destinations = new List<string>();
        }

        public List<string> destinations;

        private void NewDestination_Load(object sender, EventArgs e){
            comboBox1.Items.Add("University of Piraeus");
            comboBox1.Items.Add("Cafe-Restaurant");
            comboBox1.Items.Add("Home");

            comboBox2.Items.Add("Car");
            comboBox2.Items.Add("Public Transport");
            comboBox2.Items.Add("Walk");

            comboBox3.Items.Add("French Coffee");
            comboBox3.Items.Add("Greek Coffee");
            comboBox3.Items.Add("Black Coffee");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);

            if(selected == "Home") {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else if(selected == "Cafe-Restaurant") {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else {
                panel1.Visible = false;
                panel2.Visible = false;
            }
        }

        private void AnotherDestButton_Click(object sender, EventArgs e) {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            destinations.Add(selected);
        }
    }
}
