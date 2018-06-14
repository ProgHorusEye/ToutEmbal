using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    class Production
    {
        /// <summary>
        /// déclaration des variables
        /// </summary>
        private float boxErrorHour = 0;//nombre de boite en erreur par heure
        private double caculErrorHour = 0;//variable du taux d'erreur au total des erreurs
        private int boxInHourMax = 0;//variable du nombre de boite max
        private int numberBoxMax = 0;//variable du nombre de box maximum à construire
        private string type;//type de boite
        private int compteurboxe;//compteur de boite
        private double calculErrorTotal = 0;//variable de calcul du taux d'erreur total
        private bool prod = false;//variable bool de production en cours ou pas

        /// <summary>
        /// Get set des valeurs
        /// </summary>
        public float BoxErrorHour{get{return boxErrorHour;}set{boxErrorHour = value;}}
        public double CaculErrorHour{get{return caculErrorHour;}set{caculErrorHour = value;}}
        public double CalculErrorTotal{get{return calculErrorTotal;}set{calculErrorTotal = value;}}
        public int Compteurboxe{get{return compteurboxe;}set{compteurboxe = value;}}
        public bool Prod{get{return prod;}set{prod = value;}}
        public int NumberBoxMax{get{return numberBoxMax;}set{numberBoxMax = value;}}

        /// <summary>
        /// Constructeur de la production
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_boxInHourMax"></param>
        /// <param name="_numberBoxMax"></param>
        public Production(string _type, int _boxInHourMax, int _numberBoxMax)
        {
            this.type = _type;
            this.boxInHourMax = _boxInHourMax;
            this.numberBoxMax = _numberBoxMax;
        }

        public void Start()
        {
            
            if (compteurboxe == numberBoxMax)//si le nombre de boite construite et égale au nombre de boite total à construire
            {
                prod = false;//prod à faux, je stoppe la production
            }

            caculErrorHour = 0;//remise à zéro des des calculs d'erreur à l'heure

            int i = 0;//initialisation de i à 0

            while (i < boxInHourMax && compteurboxe < numberBoxMax && prod)//tant que le nombre de caisse que je produit est inférieure au nombre maximum de caisse à créer en 1 h (1clique de timer)
            {//et le total des caisses construites est inférieure au maximum de boite à construire
             //et que le production est en cours

                Box box = new Box(type);//je crée une caisse de type A, B ou C
                i++;//j'incrémente mon compteur
                
                if (box.IsGood)//si m caisse est bonne
                {
                    compteurboxe++;//je l'ajoute à mes bonnes boites
                }
                else
                {
                    boxErrorHour += 1;//sinon je compte la caisse dans les caisses défectueuses
                    caculErrorHour = Math.Round(boxErrorHour / boxInHourMax, 4);//calcul du taux d'erreur à l'heure
                    calculErrorTotal = Math.Round(boxErrorHour / compteurboxe, 4);//calcul du taux d'erreur total
                }
            }
        }
    }  
    
}
