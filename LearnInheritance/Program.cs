using System;
/*
Dette er et prosjekt fra Codecademy.com for å vise enkelt hvordan inheritance fungerer.
Anbefaler å starte med å se gjennom filene i rekkefølgen: IAutomobile.cs - Vehicle.cs - Sedan.cs - Truck.cs.
IAutomobile er et interface. Det er normalt å kalle interface klassene med stor "I" foran.
Tools.cs er bare for å få tilfeldig genererte skiltnummer.

Her i Program.cs kaller man på nye instanser av klassene for å lage objekter av de, og man kaller på de forskjellige metodene. 
I denne koden skrives teksten som printes ut i hver klasse.
 */
namespace LearnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ny instanse av Sedan klassen kalt "s". Denne Sedanen har en fart på 60 km/h fra start. Derfor Sedan(60).
            Sedan s = new Sedan(60);
            //Her er det instansen "s" som kaller på Describe() metoden, og siden den er fra Sedan klassen kommer beskrivelsen fra Sedan.
            Console.WriteLine(s.Describe());
            // Call SpeedUp() here //Her skal "s" kalle på SpeedUp();
            s.SpeedUp();
            Console.WriteLine(s.Describe()); //Her kaller den på Describe() igjen for å fortelle de nye verdiene etter at forskjellige metoder har blitt kalt.

            //Ny instanse av Truck som også må ha med vekt. Dette forklares nærmere i Truck klassen.
            //Her er det meste  likt som "s" innstansen over.
            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());
            // Call SlowDown() here
            t.SlowDown();
            Console.WriteLine(t.Describe());

            //Ny instanse av Bicycle. Her har jeg kalt SpeedUp() to ganger for å se hva som skjer når du kaller den for mye for Bicycle.
            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());
            // Call SpeedUp() here
            b.SpeedUp();
            Console.WriteLine(b.Describe());
            b.SpeedUp();
            Console.WriteLine(b.Describe());//Her kjører den fortsatt en forklaring selv om farten ikke har endret seg bare for å vise at farten holder seg.
        }
    }
}
