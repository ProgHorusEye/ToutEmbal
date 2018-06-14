using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbal
{
    class Box
    {
        /// <summary>
        /// Création de ma boite
        /// </summary>
        private static Random Alea = new Random();//déclaration et instanciation d'une methode aléatoire
        private bool isGood;//booléen pour contenir la valeur bonne ou pas bonne de ma boite
        private string typeBox;//type de boite A, B ou C
        public bool IsGood { get => isGood; set => isGood = value; }//assesseur de la viabilité de ma boite

        /// <summary>
        /// constructeur de ma boite
        /// </summary>
        /// <param name="_typeBox"></param>
        public Box(string _typeBox)//type de boite
        {
            this.typeBox = _typeBox;
            this.isGood = (Alea.NextDouble() >= 0.01);//calcul aléatoire pour savoir si ma boite va être bonne ou pas
        }
        
        

        
    }
}
