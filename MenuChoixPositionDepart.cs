using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuCavalier
{
    public partial class MenuChoixPositionDepart : Form
    {
        public int x;
        public int y;
        public MenuChoixPositionDepart()
        {
            InitializeComponent();
        }

        private void PremierCoupCoord_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.label1.Text = "Choisir la case départ";
            this.groupBox1.Text = "Position de la case Départ ";
            this.label3.Text = "N# de la ligne";
            this.label4.Text = "N# de la colonne";
            this.button2.Text = "Lancer le Jeu";

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Random aleat = new Random();
            this.x = aleat.Next(0, 8);
            this.y = aleat.Next(0, 8);

            this.textBox1.Text = " "+(this.x+1);
            this.textBox2.Text = " "+(this.y+1);

        }
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.textBox1.Text, out this.x);
            this.x -= 1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.textBox2.Text, out this.y);
            this.y -= 1;
        }

        private void MenuChoixPositionDepart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de quitter l'application du jeu ? ", " Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            JeuForm newGame = new JeuForm(this);
            newGame.ShowDialog();
            
        }
    }
}
