using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoPTApplication.DataBase
{
    class Animal
    {
        int code_Animal;
        string nom_Animal;
        int poids_Animal;
        public int Code_Animal
        {
            get { return code_Animal; }
            set { code_Animal = value; }
        }
        public string Nom_Animal
        {
            get { return nom_Animal; }
            set { nom_Animal = value; }
        }
        public int Poids_Animal
        {
            get { return poids_Animal; }
            set { poids_Animal = value; }
        }
        public override string ToString()
        {
            return Nom_Animal + ", pèse " + Poids_Animal.ToString();
        }




    }
}
