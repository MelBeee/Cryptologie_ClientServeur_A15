using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_Algo1CS;
using DLL_Algo2CS;
using DLL_Algo3CS;
using System.IO;

namespace Cryptologie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //--- CRYPTER UNE CHAINE DE CARACTERE ---\\

        // Fonction qui ouvre un OpenFileDialog pour permettre à l'utilisateur d'aller chercher un fichier et de l'importer.
        private void BTN_LoadNormal_Click(object sender, EventArgs e)
        {
            if (OFD_Load.ShowDialog() == DialogResult.OK)
            {
                TB_Normal.Text = File.ReadAllText(OFD_Load.FileName);
            }
        }

        // Fonction qui ouvre un SaveFileDialog pour permettre a l'utilisateur d'aller sauvegarder son texte crypter dans un fichier.
        private void BTN_SaveNormal_Click(object sender, EventArgs e)
        {
            if (SFD_Save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SFD_Save.FileName, TB_Normal.Text);
            }
        }

        // Event de click sur le bouton Crypter
        private void BTN_Crypter_Click(object sender, EventArgs e)
        {
            // Va chercher la valeur dans le NumericUpdown de la clé de cryptage
            int Cle1 = Int32.Parse(numericUpDown1.Value.ToString());

            // Verifie quel algorithme a été selectionné et appel la fonction Chiffre correspondante
            if (RB_Addition.Checked)
            {
                TB_Normal.Text = Algo3.Chiffrer(TB_Normal.Text);
            }
            if (RB_Circulaire.Checked)
            {
                TB_Normal.Text = Algo2.Chiffrer(TB_Normal.Text, Cle1);
            }
            if (RB_Rotation.Checked)
            {
                TB_Normal.Text = Algo1.Chiffrer(TB_Normal.Text, Cle1);
            }

        }

        // Event du clavier qui permet de faire qque chose a chaque fois que le texte change dans le textbox
        private void TB_Normal_TextChanged(object sender, EventArgs e)
        {
            if (TB_Normal.Text != "")
                BTN_SaveNormal.Enabled = true;
            else
                BTN_SaveNormal.Enabled = false;
        }

        //--- DECRYPTER UNE CHAINE DE CARACTERE ---\\

        // Fonction qui ouvre un OpenFileDialog pour permettre à l'utilisateur d'aller chercher un fichier et de l'importer.
        private void BTN_LoadCrypte_Click(object sender, EventArgs e)
        {
            if (OFD_Load.ShowDialog() == DialogResult.OK)
            {
                TB_Crypte.Text = File.ReadAllText(OFD_Load.FileName);
            }
        }

        // Fonction qui ouvre un SaveFileDialog pour permettre a l'utilisateur d'aller sauvegarder son texte crypter dans un fichier.
        private void BTN_SaveCrypte_Click(object sender, EventArgs e)
        {
            if (SFD_Save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SFD_Save.FileName, TB_Crypte.Text);
            }
        }

        // Event de click sur le bouton decrypter
        private void BTN_Decrypter_Click(object sender, EventArgs e)
        {
            // Va chercher la valeur de la cle dans le numericupdown
            int Cle1 = Int32.Parse(numericUpDown1.Value.ToString());

            // Verifie quel algorithme a ete choisi
            if (RB_Addition.Checked)
            {
                TB_Crypte.Text = Algo3.Dechiffrer(TB_Crypte.Text);
            }
            if (RB_Circulaire.Checked)
            {
                TB_Crypte.Text = Algo2.Dechiffrer(TB_Crypte.Text, Cle1);
            }
            if (RB_Rotation.Checked)
            {
                TB_Crypte.Text = Algo1.Dechiffrer(TB_Crypte.Text, Cle1);
            }
        }

        // Event du clavier qui permet de faire qque chose a chaque fois que le texte change dans le textbox
        private void TB_Crypte_TextChanged(object sender, EventArgs e)
        {
            if (TB_Crypte.Text != "")
                BTN_SaveCrypte.Enabled = true;
            else
                BTN_SaveCrypte.Enabled = false;
        }

        //--- FORM D'AIDE ---\\

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Aide form = new Aide();

            form.Show();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Arrow;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }
    }
}
