using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testMotorsykkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 5
            //I C# så trenger man ikke importere class-en

            //Oppg 6
            motorsykkel obj1 = new motorsykkel("Kawasaki","LC 2291",33000);
            motorsykkel obj2 = new motorsykkel("Ducati", "XB 0203", 5600);
            motorsykkel obj3 = new motorsykkel("BMW", "AA 0810", 112000);

            //Oppg 7
            Console.WriteLine(obj3.kmDriven);
            obj3.drive(10);
            Console.WriteLine(obj3.kmDriven);

            Console.ReadLine();
        }
    }

    //Oppg 1
    public class motorsykkel //Definerer den nye klassen
    {
        //Definerer de tre verdiene til motorsykkelen
        public string make; 
        public string regNr;
        public int kmDriven;

        //Denne konstruktøren kalles når man lager en ny motorsykkel
        public motorsykkel(string make, string regNr, int kmDriven)
        {
            //Lagrer parametrene som ble gitt udner danningen som verdiene i classen. Disse verdiene tilhører kun dette objectet (derav "this."
            this.make = make; 
            this.regNr = regNr;
            this.kmDriven = kmDriven;
        }
        
        //Oppg 2
        //denne metoden kan kjøres på et objekt
        public void drive(int km)
        {
            this.kmDriven += km; //Legger til mengden km oppgitt i parameteret på kilometerstanden til objektet metoden ble kjørt på
        }

        //Oppg 3
        //Denne metoden trengs ikke fordi du kan ta "navn.kmDriven", dette er kun hvis verdiene er private og ikke public somd e er i vårt tilfelle
        public int getKm()
        {
            return this.kmDriven;
        }

        //Oppg 4
        public void skrivUt()
        {
            Console.WriteLine($"Merke: {this.make}");
            Console.WriteLine($"Registreringsnummer: {this.regNr}");
            Console.WriteLine($"Kilometerstand: {this.kmDriven}");
        }
    }
}
