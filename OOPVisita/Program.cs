using OOPVisita;

namespace OOPVista
{
    class Program
    {
        static void Main()
        {

            string motiuUrgencia = "Fimosis";

            DateTime fecha = new DateTime(2024, 2, 13);

            Visita visita = new Visita("51250429F", "Arnau", fecha, motiuUrgencia);

            Pacient pacient = new Pacient("Arnau", "Blanca", 18, false, "51250429F", "Arnau", fecha, motiuUrgencia);

            Propietari propietari = new Propietari("51250429F", "Eric", "Requenita Jimenez", 666666666, "51250429F", "Arnau", fecha, motiuUrgencia);


            System.Console.WriteLine("Pacient: " + pacient.Nom + " Raça: " + pacient.Raça + " Edat: " + pacient.Edat + " Vacunat: " + pacient.Vacunat);
            System.Console.WriteLine("Propietari: " + propietari.Dni + " Nom: " + propietari.Nom + " Cognoms: " + propietari.Cognoms + " Telefon: " + propietari.Telefon);
            System.Console.WriteLine("Visita: " + visita.Propietari + " Pacient: " + visita.Pacient + " Data: " + visita.Data + " Motiu: " + visita.Motiu);




           

        }
    }
}
