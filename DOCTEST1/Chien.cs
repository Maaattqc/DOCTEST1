using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOCTEST1
{
    /// <summary>
    /// Ceci est une classe qui genere des chiens
    /// </summary>
    public class Chien
    {
        private int nombreDePattes;
        private int nombreDeTête;
        /// <summary>
        /// le constructeur par defaut crééer des chiens
        /// </summary>
        /// <param name="nombreDePattes"></param>
        /// <param name="nombreDeTête"></param>
        public Chien(int nombreDePattes, int nombreDeTête)
        {
            this.nombreDePattes = nombreDePattes;
            this.nombreDeTête = nombreDeTête;
        }

        /// <summary>
        /// la fonction multiplie les tetes
        /// </summary>
        /// <param name="nombre"></param>
        public void MultiplierTete(int nombre) 
        {
            this.nombreDeTête = nombreDeTête * nombre;
        }

        /// <summary>
        /// retourne une belle phrase
        /// </summary>
        /// <returns></returns>
        public string ReturnBeautifulSentence()
        {
            return $"Le chien crééer a {nombreDePattes} patte(s) et {nombreDeTête} tête(s)";
        }
    }
}
