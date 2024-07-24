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
    public partial class MenuJeu : Form
    {
        public MenuJeu()
        {
            InitializeComponent();
        }

        private void MenuJeuForm_Load(object sender, EventArgs e)
        {
 
            this.label1.Text = "Bienvenue au Jeu du Cavalier";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le principe est le suivant : \n"
                                + "\n       1. Le joueur choisit une case de départ parmi les 64 disponible." +
                                 "\n       2. Ensuite, il se déplace avec un mouvement en 'L' (4 cases), verticalement ou horizontalement." +
                                 "\n       3. Si une case a été parcouru, le joueur ne pourra pas la re-parcourir." +
                                 "\n       4. Le joueur doit parcourir le maximum de cases possibles." +
                                 "\n       5. Si aucune case ne peut être parcouru (tous les cases en mouvement de 'L' sont parcourus), le jeu s'arrêtera. Le joueur pourra voir son score affiché à l'écran" + "\n\nCe jeu peut se jouer en famille, ou entre les amis, et ainsi comparer les différents scores. Le déclaré vainqueur est évidemment celui qui a parcouru le plus de cases et donc remporté le plus de point." +
                                 "\n\nBon jeu les cavaliers!", "Comment joueur ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuChoixPositionDepart premierCoup = new MenuChoixPositionDepart();
            premierCoup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter l'application du jeu Cavalier ? ", " Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
