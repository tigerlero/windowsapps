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
    public partial class Map : Form {
        public Map() {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e) {
            PictureBox.Image = Properties.Resources.map;
        }
    }
}
