using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Agence_Immobiliare
{
    class Bien
    {
        string _reference;
        string _adresse;
        int _surface;
        int _nombrePiece;
        string _type;
        string _statut;
        double _prix;

        public Bien(string reference, string adresse, int surface, int nombrePiece, string type, string statut, double prix)
        {
            _reference = reference;
            _adresse = adresse;
            _surface = surface;
            _nombrePiece = nombrePiece;
            _type = type;
            _statut = statut;
            _prix = prix;
        }

        public string Reference { get => _reference; set => _reference = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public int Surface { get => _surface; set => _surface = value; }
        public int NombrePiece { get => _nombrePiece; set => _nombrePiece = value; }
        public string Type { get => _type; set => _type = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public void setPrix(double newprix)
        {
            _prix = newprix;
        }

        public string getReference()
        {
            return _reference;
        }
        public string getAdresse()
        {
            return _adresse;
        }
        public int getSurface()
        {
            return _surface;
        }
        public int getNbPiece()
        {
            return _nombrePiece;
        }
        public string getType()
        {
            return _type;
        }
        public string getStatut()
        {
            return _statut;
        }
        public double getPrix()
        {
            return _prix;
        }
        public void affiche()
        {
            Console.WriteLine("Numéro de bien : " + _reference);
            Console.WriteLine("Adresse : " + _adresse);
            Console.WriteLine("Surface habitable : " + _surface);
            Console.WriteLine("Nombre de piece : " + _nombrePiece);
            Console.WriteLine("Type : " + _type);
            Console.WriteLine("Statut : " + _statut);
            Console.WriteLine("Prix : " + _prix);
            Console.WriteLine("----------------------------------");
        }
        public double rapportAnnuel()
        {
            double gain;
            gain = 0;

            if (_statut == "L")
            {
                gain = _prix * 12;
                Console.WriteLine("Le bien rapporte " + gain + " euros par an.");
                Console.WriteLine("--------------------------------");
            }
            if (_statut == "AL")
            {
                gain = _prix * 12;
                Console.WriteLine("Le bien rapporte " + gain + " euros par an.");
                Console.WriteLine("--------------------------------");
            }
            if (_statut == "V")
            {
                gain = 0;
                Console.WriteLine("Le bien rapporte " + gain + " euros par an.");
                Console.WriteLine("--------------------------------");
            }
            if (_statut == "AV")
            {
                gain = 0;
                Console.WriteLine("Le bien rapporte " + gain + " euros par an.");
                Console.WriteLine("--------------------------------");
            }
            
            return gain;
        }
    }
}
