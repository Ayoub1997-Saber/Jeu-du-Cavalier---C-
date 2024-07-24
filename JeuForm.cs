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
    public partial class JeuForm : Form
    {
        private Button[,] grilleEchiquier;
        private int NumberOfMoving;
        public Button CurrentCase = new Button();
        public MenuChoixPositionDepart position1;
        public int a, c;

        public JeuForm(MenuChoixPositionDepart premierCoup)
        {
            position1 = premierCoup;
            InitializeComponent();
        }

        private void JeuForm_Load(object sender, EventArgs e)
        {
            this.NumberOfMoving = 0;
            this.Text = "Jeu du Cavalier";

            // creation de l'echequier
            
            this.grilleEchiquier = new Button[64, 64];
           
            for (int line = 0; line < 8; line++)
            
                for (int column = 0; column < 8; column++)
                {
                    Button MyButton = new Button();
                    MyButton.Location = new Point(line * 100, column * 100);
                    MyButton.Size =  new Size(100, 100);

                    if ((line + column) % 2 == 0)
                        MyButton.BackColor = Color.SandyBrown;
                    else
                        MyButton.BackColor = Color.SaddleBrown;


                    MyButton.Click += new EventHandler(this.valideCoup);
                    this.Controls.Add(MyButton);
                    grilleEchiquier[column,line] = MyButton;
                }


            

            grilleEchiquier[position1.x, position1.y].Enabled = false;
            grilleEchiquier[position1.x, position1.y].Image = Image.FromFile("img/cheval2.png"); 
            this.CurrentCase = grilleEchiquier[position1.x, position1.y];

            NumberOfMoving = 1;
            this.score.Text = " Score : " + NumberOfMoving;

        }
        private void valideCoup(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;
                if(b.Enabled==false)
                    MessageBox.Show("Le cavalier a deja été sur cette case ","erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if(valideDeplacement(b))
                {
                    this.CurrentCase.Image = null;
                    this.CurrentCase.Enabled = false;
                    this.CurrentCase.BackColor = Color.ForestGreen;


                    this.NumberOfMoving++;
                    b.Image = Image.FromFile("img/cheval2.png");
                    this.CurrentCase = b;
                    this.score.Text = " Score : " + NumberOfMoving;

                }
                else
                    MessageBox.Show("Le déplacement de votre cavalier est erroné !" +"\n"+"Veuillez vous déplacer en 'L' s'il vous plaît !",
                        "Déplacement Invalide",MessageBoxButtons.OK,MessageBoxIcon.Error);

                if (NumberOfMoving == 64)
                {
                    MessageBox.Show("Bien joué ! Vous avez réussi a parcourir toutes les cases." + "\n" + "Chapeau bas !", "BRAVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //else
                //{
                //    if (cavalierBloquer(b) == true)
                //    {
                //        MessageBox.Show("Vous Avez PERDU !!!!", "Perdu", MessageBoxButtons.OK);
                //    }
                //}


               
            }

        }

        private bool valideDeplacement(Button b)
        {
            int l1,l2;
            int c1,c2;

            GetPosition(b,out l2,out c2);
            GetPosition(this.CurrentCase, out l1, out c1);

            if ( (l1 + 1 == l2 && c1 + 2 == c2)   || (l1 - 1 == l2 && c1 + 2 == c2) ||
                (l1 - 2 == l2 && c1 - 1 == c2) || (l1 -2  == l2 && c1 + 1 == c2) ||
                (l1 - 1 == l2 && c1 - 2 == c2) || (l1 + 1 == l2 && c1 - 2 == c2) ||
                (l1 + 2 == l2 && c1 - 1 == c2) || (l1 + 2 == l2 && c1 + 1 == c2) )
            {
                return true;
            }
            else return false;


            
        }

        /// <summary>
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool cavalierBloquer(Button b)
        {
            int l1, c1;
            GetPosition(b, out l1, out c1); 

            if ((grilleEchiquier[l1 + 1 , c1 + 2].Enabled == false) && (grilleEchiquier[l1 - 1, c1 + 2].Enabled == false) &&
                (grilleEchiquier[l1 - 2, c1 - 1].Enabled == false) && (grilleEchiquier[l1 - 2, c1 + 1].Enabled == false) &&
                (grilleEchiquier[l1 - 1, c1 - 2].Enabled == false) && (grilleEchiquier[l1 + 1, c1 - 2].Enabled == false) &&
                (grilleEchiquier[l1 + 2, c1 - 1].Enabled == false )&& (grilleEchiquier[l1 + 2, c1 + 1].Enabled == false))
            {
                return true;
                
            }
            else 
                return false;

        }



        /// <summary>
        /// retourne la position d'un bouton sur l'échequier
        /// </summary>
        /// <param name="b"> bouton </param>
        /// <param name="l"> retournera la position ligne du bouton</param>
        /// <param name="c"> retournera la position colonne du bouton</param>
        private void GetPosition(Button b, out int l, out int c)
        {
            l = c = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grilleEchiquier[j, i] == b)
                    {
                        l = j;
                        c = i;
                        return;
                    }
                }
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grilleEchiquier[i, j].Enabled = true;
                    if ((i+ j) % 2 == 0)
                        grilleEchiquier[i,j].BackColor = Color.SandyBrown;
                    else
                        grilleEchiquier[i,j].BackColor = Color.SaddleBrown;

                }
            }

            this.NumberOfMoving = 0;
            this.score.Text = " Score : " + NumberOfMoving;


        }

        private void JeuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter la Partie ? ", " Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
                

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
