using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_Practicum_week1
{
    class Program
    {
        static void Main(string[] args)
        {

            var nieuwArray = new NawArrayOngeordend(20);

            NawArrayOngeordend array = new NawArrayOngeordend(20);
            array.VoegToe(new NAW("Persoon 1", "Adres 1", "Woonplaats 1"));
            array.VoegToe(new NAW("Persoon 2", "Adres 2", "Woonplaats 2"));
            array.VoegToe(new NAW("Persona non grata", "Adres 3", "Woonplaats 3"));
            array.VoegToe(new NAW("Persoon 4", "Adres 4", "Woonplaats 2"));
            array.VoegToe(new NAW("Persoon 1", "Adres 5", "Woonplaats 1"));
            array.VoegToe(new NAW("Persoon 6", "Adres 6", "Woonplaats 2"));
            array.VoegToe(new NAW("Persona non grata", "Adres 7", "Woonplaats 3"));
            array.VoegToe(new NAW("Persoon 8", "Adres 8", "Woonplaats 2"));
            array.VoegToe(new NAW("Persoon 9", "Adres 9", "Woonplaats 1"));
            array.VoegToe(new NAW("Persoon 10", "Adres 10", "Woonplaats 2"));

            array.Show();

            
            var persoon = new NAW("Persoon 1", "Adres 5", "Woonplaats 1");
           // int index = array.Zoek(persoon);
        //    System.Console.WriteLine("Persoon gevonden op index {0}", index);
            
            System.Console.WriteLine("Persoon 4 gevonden op index {0}\n", array.ZoekNaam("Persoon 4"));
            System.Console.WriteLine("{0} items met naam Persona non grate zijn verwijderd", array.VerwijderAlleMetNaam("Persona non grata"));

            System.Console.WriteLine("Persoon 4 gevonden op index {0}\n", array.ZoekNaam("Persoon 4"));
            System.Console.WriteLine("Persona non grata gevonden op index {0}\n", array.ZoekNaam("Persona non grata"));
            array.Show();

            var persoon1 = new NAW("Koen","Hoekwal","Veldhoven");
            var persoon2 = new NAW("Koen","Aoekwal","Veldhoven");
            System.Console.WriteLine("Koen,Hoekwal,Veldhoven en Koen,Hoekwal,Breda = {0}",persoon1.CompareTo(persoon2));
            
            System.Console.ReadKey();
        }
    }
}
