using System;

namespace OOPVisita
{
    public class Visita
    {
        protected string propietari;
        protected string pacient;
        protected DateTime data;
        protected string motiu;

        public string Propietari
        {
            get { return propietari; }
            set { propietari = value; }
        }
        public string Pacient
        {
            get { return pacient; }
            set { pacient = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Motiu
        {
            get { return motiu; }
            set { motiu = value; }
        }

        public Visita(string propietari, string pacient, DateTime data, string motiu)
        {
            Propietari = propietari;
            Pacient = pacient;
            Data = data;
            Motiu = motiu;
        }

        public override string ToString()
        {
            return $"Propietari: {Propietari}, Pacient: {Pacient}, Data: {Data}, Motiu: {Motiu}";
        }



    }

    
}
