using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{

    /// <summary>
    /// Cette classe est utilisée pour initialisé un ou plusieurs chien(s)
    /// <code>
    /// Chien maClasse = new Chien();
    /// maClasse.CalculerAge(vraiAge,trancheAge)
    /// </code>
    /// <code>
    /// Chien maClasse = new Chien();
    /// maClasse.Aboyer()
    /// </code>
    /// </summary>
    public class Chien
    {

        private string nom;
        private int age;
        private string race;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom">C'est le nom du chien</param>
        /// <param name="age">L'âge du chien</param>
        /// <param name="race">La race du chien</param>
        public Chien(string nom, int age, string race)
        {
            this.Nom = nom;
            this.Age = age;
            this.Race = race;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }
        public string Race { get => race; set => race = value; }

        /// <summary>
        /// Cette event se déclenche lorsque la position change
        /// </summary>
        private event EventHandler<Chien> PositionChanged;

        /// <summary>
        /// Cette fonction est simplement présente pour donner l'aboiement du chien.
        /// </summary>
        /// <returns>Cette retourne une string décrivant comment aboit le chien</returns>
        private string Aboyer()
        {
            return "Woof Woof";
        }

        /// <summary>
        /// Cette fonction est simplement présente pour donner dans quelle tranche d'âge se situe le chien.
        /// </summary>
        /// <param name="vraiAge">L'âge du chien</param>
        /// <param name="trancheAge">La tranche d'âge du chien</param>
        /// <returns>Cette fonction retourne la tranche d'âge</returns>

        private string CalculerAge(int vraiAge,string trancheAge)
        {
            age = vraiAge * 7;
            if (age<=14)
            {
                trancheAge = "Jeune chien";
            }
            else if(age>14 && age<=49)
            {
                trancheAge= "Chien adulte";
            }
            else
            {
                trancheAge = "Vieux chien";
            }
            return trancheAge;
        }

    }
}
