using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia {
    public partial class HelpForm : Form {
        public HelpForm() {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e) {
            richTextBox1.Clear();

            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
            richTextBox1.SelectedText = "Δήλωση βασικών προορισμών ημέρας" + "\n\n";

            richTextBox1.SelectionFont = new Font("Arial", 9);
            richTextBox1.SelectedText = "1) Πατήστε το κουμπί \"Set Destinations\"." + "\n\n"
                + "2) Από το μενού προορισμών που θα εμφανιστεί, επιλέξτε προορισμό." + "\n\n"
                + "3) Ορίστε την ώρα άφιξης. Το πρώτο field είναι για την ώρα και το δεύτερο για τα λεπτά. Η ώρα γράφεται με αριθμούς και ακολουθεί την στρατιωτική σύμβαση (πχ. 14:00 είναι δύο μετά μεσημβρίας)." + "\n\n"
                + "4) Απαντήστε στις ερωτήσεις που θα σας εμφανιστούν. Μέρος των ερωτήσεων εξαρτάται από τον προορισμό που επιλέξατε." + "\n\n";

            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectedText = "4.1) Εάν επιλέξατε για προορισμό καφετέρια, θα ερωτηθείτε εάν θέλετε να παραγγείλετε online. Εάν απαντήσετε καταφατικά, θα έχετε την επιλογή να επιλέξετε καφέ από το μενού, καθώς και την ποσότητα που θέλετε. Ο καφές θα είναι έτοιμος να τον παραλάβετε όταν φτάσετε στο κατάστημα." + "\n\n"
                + "4.2) Εάν επιλέξατε για προορισμό το σπίτι σας, έχετε την δυνατότητα να αλληλεπιδράσετε με την έξυπνη καφετιέρα του σπιτιού σας για να έχει έτοιμο καφέ όταν γυρίσετε σπίτι." + "\n\n";

            richTextBox1.SelectionIndent = 0;
            richTextBox1.SelectedText = "5) Στο κάτω μέρος της εφαρμογής υπάρχει ένα κουμπί που γράφει \"Set Another Destination\". Πατώντας το μπορείτε να προσθέσετε και νέο προορισμό, επαναλαμβάνοντας τα βήματα 1-4." + "\n\n"
                + "6) Όταν είστε ικανοποιημένοι με την δήλωση, πατήστε το κουμπί \"Finish\" για να ολοκληρώσετε την δήλωση προορισμών της ημέρας σας." + "\n\n"
                + "7) Στην οθόνη σας θα δείτε το πλάνο της ημέρας σας, καθώς επίσης και χάρτη για την διαδρομή σας." + "\n\n\n";


            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
            richTextBox1.SelectedText = "Αλληλεπίδραση με συσκευές σπιτιού" + "\n\n";

            richTextBox1.SelectionFont = new Font("Arial", 9);
            richTextBox1.SelectedText = "1) Πατήστε το κουμπί \"House Devices\"." + "\n\n"
                + "2) Από το μενού που θα εμφανιστεί, επιλέξτε τη συσκευή με την οποία θέλετε να αλληλεπιδράσετε." + "\n\n";

            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectedText = "2.1) Εάν επιλέξατε “TV” μπορείτε να αλληλεπιδράσετε με την τηλεόραση του σπιτιού. Μπορείτε να την ανοίξετε και να την κλείσετε, να αλλάξετε κανάλι και ένταση ήχου." + "\n\n"
                + "2.2) Εάν επιλέξατε “Water Heater” (θερμοσίφωνας), έχετε την επιλογή να τον ανάψετε και να τον κλείσετε." + "\n\n"
                + "2.3) Εάν επιλέξατε “Coffee Machine” (καφετιέρα), μπορείτε να την ενεργοποιήσετε για να σας ετοιμάσει καφέ." + "\n\n";

            richTextBox1.SelectionIndent = 0;
            richTextBox1.SelectedText = "3) Εάν παρουσιαστεί κάποιο πρόβλημα, θα λάβετε αντίστοιχο μήνυμα." + "\n\n\n";


            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
            richTextBox1.SelectedText = "Αλληλεπίδραση με ηλικιωμένους" + "\n\n";

            richTextBox1.SelectionFont = new Font("Arial", 9);
            richTextBox1.SelectedText = "1) Πατήστε το κουμπί “Elderly Check”, στην κορυφή της εφαρμογής." + "\n\n"
                + "2) Θα σας γίνει η εξής ερώτηση: “Do you need help?”" + "\n\n"
                + "3) Απαντήστε αναλόγως. Εάν δεν απαντήσετε σε κάποιο χρονικό διάστημα, ή εάν απαντήσετε αρνητικά, ο υπολογιστής θα ειδοποιήσει ένα γιατρό και τους κοντινότερους συγγενείς σας.";

            //Set scrollbar position
            richTextBox1.Select(0, 0);
            richTextBox1.ScrollToCaret();
        }
    }
}
