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
    public partial class SmartPlanForm : Form{
        public SmartPlanForm(){
            InitializeComponent();

            currDestinations = new List<string>();
            allDestinations = new List<string>();

            allDestinations.Add("University of Piraeus");
            allDestinations.Add("Cafe-Restaurant");
            allDestinations.Add("Home");
        }

        public List<string> currDestinations;
        public List<string> allDestinations;

        private void SmartPlan_Load(object sender, EventArgs e) {
            foreach(string dest in allDestinations){
                DestinationsBox.Items.Add(dest);
            }

            TransportBox.Items.Add("Car");
            TransportBox.Items.Add("Public Transport");
            TransportBox.Items.Add("Walk");

            comboBox3.Items.Add("French Coffee");
            comboBox3.Items.Add("Greek Coffee");
            comboBox3.Items.Add("Black Coffee");
        }

        /* Main menu buttons */
        private void SetDestinations_Click(object sender, EventArgs e){
            NewDestPanel.Visible = true;
        }

        private void HouseDevicesButton_Click(object sender, EventArgs e) {
            HouseDevices.Visible = true;
        }

        private void FallDown_Click(object sender, EventArgs e) {
            Timer.Enabled = true;
            ElderlyPanel.Visible = true;
        }

        /* Back Buttons */
        private void BackButton1_Click(object sender, EventArgs e) {
            ElderlyPanel.Visible = false;
            Timer.Enabled = false;
        }

        private void BackButton2_Click(object sender, EventArgs e) {
            NewDestPanel.Visible = false;
        }

        private void BackButton3_Click(object sender, EventArgs e) {
            HouseDevices.Visible = false;
        }

        /* Destination Panel */
        private void DestBox_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = DestinationsBox.GetItemText(DestinationsBox.SelectedItem);

            if(selected == "Home") {
                panel1.Visible = false;
                panel2.Visible = true;
            } else if(selected == "Cafe-Restaurant") {
                panel1.Visible = true;
                panel2.Visible = false;
            } else {
                panel1.Visible = false;
                panel2.Visible = false;
            }
        }

        private void AnotherDestButton_Click(object sender, EventArgs e) {
            string selected = DestinationsBox.GetItemText(DestinationsBox.SelectedItem);
            currDestinations.Add(selected);

            //Reset destination combobox
            DestinationsBox.SelectedIndex = -1;
            DestinationsBox.Text = "Choose Destination";

            DestinationsBox.Items.Clear();
            foreach(string dest in allDestinations) {
                if(currDestinations.Contains(dest)) {
                    //If dest has been chosen by the user as
                    //destination, continue and don't add it
                    continue;
                }

                DestinationsBox.Items.Add(dest);
            }

            if(selected != "") {
                currDests.Items.Add(selected);
                currDests.Visible = true;
                currDests.Text = "Remove Destinations";
            }

            //Reset transportation
            TransportBox.SelectedIndex = -1;
            TransportBox.Text = "Choose Transport";
        }

        private void currDests_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = currDests.GetItemText(currDests.SelectedItem);
            if(selected == "") {
                return;
            }

            currDestinations.Remove(selected);
            DestinationsBox.Items.Add(selected);

            currDests.SelectedIndex = -1;
            currDests.Items.Clear();

            foreach(string dest in allDestinations) {
                if(!currDestinations.Contains(dest)) {
                    //If dest has not been chosen by the user as
                    //destination, continue and don't add it
                    continue;
                }

                currDests.Items.Add(dest);
            }

            if(currDests.Items.Count == 0) {
                currDests.Visible = false;
            }
        }

        private void currDests_Leave(object sender, EventArgs e) {
            currDests.Text = "Remove Destinations";
        }

        private void currDests_MouseClick(object sender, MouseEventArgs e) {
            currDests.Text = "Remove Destinations";
        }

        private void Hours_Leave(object sender, EventArgs e) {
            string text = Hours.Text;
            int n;
            bool isNumeric = int.TryParse(text, out n);

            if(!isNumeric) {
                Hours.Text = "0";
            } else if(n > 23 || n < -1) {
                Hours.Text = "0";
            }
        }

        private void Minutes_Leave(object sender, EventArgs e) {
            string text = Minutes.Text;
            int n;
            bool isNumeric = int.TryParse(text, out n);

            if(!isNumeric) {
                Minutes.Text = "0";
            } else if(n > 23 || n < -1) {
                Minutes.Text = "0";
            }
        }

        /* Elderly Panel */
        private void Timer_Tick(object sender, EventArgs e) {
            Timer.Enabled = false;
            ElderlyButtonYes.Visible = false;
            ElderlyButtonNo.Visible = false;
            ElderlyLabel.Text = "Calling for help...";
        }

        private void ElderlyButtonYes_Click(object sender, EventArgs e) {
            Timer.Enabled = false;

            if(ElderlyLabel.Text == "Do you need help?") {
                ElderlyLabel.Text = "Do you need a doctor?";
            } else if(ElderlyLabel.Text == "Do you need a doctor?") {
                ElderlyLabel.Text = "Do you need medicine?";
            } else if(ElderlyLabel.Text == "Do you need medicine?") {
                ElderlyLabel.Text = "Calling for help, please stand by...";
                ElderlyButtonYes.Visible = false;
                ElderlyButtonNo.Visible = false;
            }
        }

        private void ElderlyButtonNo_Click(object sender, EventArgs e) {
            Timer.Enabled = false;

            if(ElderlyLabel.Text == "Do you need help?") {
                ElderlyLabel.Text = "Do you need a doctor?";
            } else if(ElderlyLabel.Text == "Do you need a doctor?") {
                ElderlyLabel.Text = "Do you need medicine?";
            } else if(ElderlyLabel.Text == "Do you need medicine?") {
                ElderlyLabel.Text = "Be careful, falling down is bad for your health.";
                ElderlyButtonYes.Visible = false;
                ElderlyButtonNo.Visible = false;
            }
        }

        /* House Devices Panel */
        private void WaterHeaterOnOff_Click(object sender, EventArgs e) {
            if(WaterHeaterOnOff.Text == "OFF") {
                WaterHeaterOnOff.Text = "ON";
                WaterHeaterOnOff.BackColor = Color.Green;
            } else {
                WaterHeaterOnOff.Text = "OFF";
                WaterHeaterOnOff.BackColor = Color.Red;
            }
        }

        private void CoffeeMachineOnOff_Click(object sender, EventArgs e) {
            if(CoffeeMachineOnOff.Text == "OFF") {
                MessageBox.Show("Insert water...");
                CoffeeMachineOnOff.Text = "ON";
                CoffeeMachineOnOff.BackColor = Color.Green;
            } else {
                CoffeeMachineOnOff.Text = "OFF";
                CoffeeMachineOnOff.BackColor = Color.Red;
            }
        }

        private void WaterHeaterButton_Click(object sender, EventArgs e) {
            WaterHeaterPanel.Visible = true;
            CoffeeMachinePanel.Visible = false;
            TVPanel.Visible = false;
        }

        private void CoffeeMachineButton_Click(object sender, EventArgs e) {
            CoffeeMachinePanel.Visible = true;
            WaterHeaterPanel.Visible = false;
            TVPanel.Visible = false;
        }

        private void TVButton_Click(object sender, EventArgs e) {
            TVPanel.Visible = true;
            CoffeeMachinePanel.Visible = false;
            WaterHeaterPanel.Visible = false;
        }

        private void TVOnOff_Click(object sender, EventArgs e) {
            if(TVOnOff.Text == "OFF") {
                TVOnOff.Text = "ON";
                TVOnOff.BackColor = Color.Green;
            } else {
                TVOnOff.Text = "OFF";
                TVOnOff.BackColor = Color.Red;
            }
        }

        private void Finish_Click(object sender, EventArgs e) {
            Map map = new Map();
            map.Show();
        }

        private void OnlineHelp_Click(object sender, EventArgs e) {
            HelpForm help = new HelpForm();
            help.Show();
        }
    }
}