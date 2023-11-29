using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Agence_Immobiliare
{
    class Agence
    {
        private List<Bien> _lesBiens;
        public Agence()
        {
            _lesBiens = new List<Bien>();     
        }
        public void ajoute(Bien b)
        {
            _lesBiens.Add(b);
        }
        public void afficheTouslesBiens()
        {
            foreach (Bien unBien in _lesBiens)
            {
                unBien.affiche();
            }
        }
        public List<Bien> DonneToutesLesMaisons()
        {
            List<Bien> Maisons = new List<Bien>();
            foreach (Bien unBien in _lesBiens)
            {
                if (unBien.getType() == "M")
                {
                    Maisons.Add(unBien);
                }
            }
            return Maisons;
        }
        public List<Bien> DonneTouslesApparts()
        {
            List<Bien> Appartements = new List<Bien>();
            foreach (Bien unBien in _lesBiens)
            {
                if (unBien.getType() == "A")
                {
                    Appartements.Add(unBien);
                }
            }
            return Appartements;
        }
        public bool EstPresent (string numBien)
        {
            bool existe;
            existe = false;
            
            foreach (Bien unBien in _lesBiens)
            {
                if (unBien.getReference() == numBien)
                {
                    existe = true;
                }
            }
            return existe;
        }
        
        public bool SupprimeBien(string numBien)
        {
            int decision = 0;
            bool supprime = false;
            Bien aSupprimer = null;

            foreach (Bien unBien in _lesBiens)
            {
                if (unBien.getReference() == numBien)
                {
                    aSupprimer = unBien;
                    decision = 1;
                }
            }
            if (decision == 1)
            {
                _lesBiens.Remove(aSupprimer);
                supprime = true;
            }
            else
            {
                supprime = false;
            }
            return supprime;
        }
    }
}
