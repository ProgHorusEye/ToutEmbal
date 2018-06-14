using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class Prod : Form
    {

        public Prod()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Déclaration des dictionnaires à utiliser
        /// </summary>
        private Dictionary<string, Production> listeprod;//Dictionnaire pour stocker les objets Production
        private Dictionary<string, ProgressBar> listeprogre;//Dictionnaire pour stocker les progressBars
        private Dictionary<string, TextBox> listecompteur;//Dictionnaire pour stocker les textbox de compteur de caisses
        private Dictionary<string, TextBox> listeErrHour;//Dictionnaire pour stocker les textbox des taux d'erreurs par heure
        private Dictionary<string, TextBox> listeErrTot;//Dictionnaire pour stocker les textbox des taux d'erreurs total

        private string choix;//déclaration de la variable stockant le choix de la production

        public string Choix { get{return choix;} set{choix = value;} }//assesseur de choix
        
        /// <summary>
        /// Au chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prod_Load(object sender, EventArgs e)
        {
            
            ///Instanciation du dictionnaire des différentes productions
            listeprod = new Dictionary<string, Production>
            {
                {"A",new Production("A", 1000, 10000)},//production A
                {"B",new Production("B", 5000, 25000)},//production B
                {"C",new Production("C", 10000, 120000)}//production C
            };

            ///Instanciation du dictionnaire des différentes progressBar
            listeprogre = new Dictionary<string, ProgressBar>
            {
                {"A",progressBarA},
                {"B",progressBarB},
                {"C",progressBarC}
            };

            ///Instanciation du dictionnaire des différentes textbox
            listecompteur = new Dictionary<string, TextBox>
            {
                {"A",tbnbcaisseA},
                {"B",tbnbcaisseB},
                {"C",tbnbcaisseC}
            };

            ///Instanciation du dictionnaire des différentes textbox
            listeErrHour = new Dictionary<string, TextBox>
            {
                {"A",tbdefheureA},
                {"B",tbdefheureB},
                {"C",tbdefheureC}
            };

            ///Instanciation du dictionnaire des différentes
            listeErrTot = new Dictionary<string, TextBox>
            {
                {"A",tbDefDemA},
                {"B",tbDefDemB},
                {"C",tbDefDemC}
            };

            ///initialisation des différentes progressebar
            progressBarA.Minimum = 1;
            progressBarA.Value = 1;
            progressBarA.Step = 1;
            progressBarB.Minimum = 1;
            progressBarB.Value = 1;
            progressBarB.Step = 1;
            progressBarC.Minimum = 1;
            progressBarC.Value = 1;
            progressBarC.Step = 1;

            timerprod.Start();//lancement du timerprod


        }

        /// <summary>
        /// je clique sur démarre A, B ou C dans le menu pour lancer une production
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Demarre_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;//je cast l'object sender en menu pour pouvoir récupérer le texte
            choix = toolStripMenuItem.Text;//le récupère le texte du menu A, B ou C pour le prendre comme choix de production
            
            if (listeprod[choix] != null)//si le choix n'est pas null donc non choisit
            {
                listeprod[choix].Prod = true;//je passe la prod en vrai pour autorisation la création de boite
                ///En cas de démarre d'une production non terminé avant
                listeprogre[choix].Value = 1;//je réinitialise ma progressbar à 1
                listeprod[choix].Compteurboxe = 0;//je remet le compteur de boite à 0
                listeprod[choix].CaculErrorHour = 0;//je remets le calcul d'erreur à l'heure à zéro
                listeprod[choix].CalculErrorTotal = 0;//je remet le compteur d'erreur total à zéro
            }

            listeprogre[choix].Maximum = Convert.ToInt32(listeprod[choix].NumberBoxMax);
            //j'initalise la valeur maximum de ma progressbar avec la valeur du nombre de caisse max de ma production
        }

        private void DemA_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// timer de production, chaque clique représente une heure, vérifie si chaque production doit être lancé ou pas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Timer(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Production> Item in listeprod)//parcours la bibliothèque de mes productions
            {
               
                if (Item.Value.Prod)//si la production est sur true
                {
                    Item.Value.Start();//je lance la fonction start de ma production
                    listecompteur[Item.Key].Text = Item.Value.Compteurboxe.ToString();//je met à jour mon nombre de boite
                    listeprogre[Item.Key].Value = Item.Value.Compteurboxe;//je met à jour la progression de pregressbar
                    listeErrHour[Item.Key].Text = Item.Value.CaculErrorHour.ToString();//je met à jour mon calcul d'erreur heure
                    listeErrTot[Item.Key].Text = Item.Value.CalculErrorTotal.ToString();//je met à jour mon calcul d'erreur total
                }
            }
        }

        /// <summary>
        /// Quand je clique sur une des productions à arrêter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArretA_Click(object sender, EventArgs e)
        {
            
            if (!listeprod[choix].Prod)//si la est déjà en arrêt
            {
                MessageBox.Show("La production est déjà arrêté", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//j'envoi un message
            else
            {
                listeprod[choix].Prod = false;//sinon prod de ma production passe à false pour arrêter la rpoduction au prochain click
            }
        }

        /// <summary>
        /// je clique sur un production à continuer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContA_Click(object sender, EventArgs e)
        {
            
            if (listeprod[choix].Prod)//si la production sur laquelle je clique n'est pas arrêté
            {
                MessageBox.Show("La production n'as pas été arêté avant", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//je délivre ce message
            else
            {
              
                if (listeprod[choix].Compteurboxe == listeprod[choix].NumberBoxMax)//si le nombre de caisse produite et égale au nombre de caisse max à produire
                {
                    MessageBox.Show("La production est complète", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }//j'indique que la production est déjà complète
                else
                {
                    listeprod[choix].Prod = true;//sinon je passe la prod à vrai pour la relancer au prochain clique
                }
            }
        }

        /// <summary>
        /// permet de fermer l'application en cliquant sur quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //boite de dialogue pour vérifier si effectivement l'app doit être fermé
            DialogResult ferme = MessageBox.Show("Voulez vous fermer l'application ?", "fermeture", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (ferme == DialogResult.OK)//si l'utilisateur à cliqué sur fermer
            {
                this.Close();//ferme l'application active
            }
        }





    }
}
