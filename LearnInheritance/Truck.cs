using System;

namespace LearnInheritance
{
    /*
    Denne klassen arver fra Vehicle.cs og implimenterer fra IAutomobile.cs. Når vi jobber med arv har vi to kategorier på klassene:
    Derived Class (child) - the class that inherits from another class.
    Base Class (parent) - the class being inherited from.
    I dette prosjektet blir Vehicle (parent) og Truck (child).
    For å arve og eller implimentere bruker man ":" kolon. Denne klassen arver fra Vehicle.cs og implimenterer fra IAutomobile som blir skilt av med "," komma.
     */
    class Truck : Vehicle, IAutomobile
    {
        //Siden denne klassen regner ut antall dekk på vekten til lastebilen i dette tilfellet må vi deklarere Weight her.
        public double Weight
        { get; }

        //Truck har sin egen konstuktør som vi kan instansiere fra. Den har også speed som parameter likt som base klassen (Vehicle.cs).
        //Her må vi riktig nok legge til weight og når vi skal instansiere klassen for som vi ser lenger ned i koden avhenger antall dekk på vekten til lastebilen.
        //base er konstruktoren til vehicle. Så  her i Truck.cs trenger vi fortsatt speed, men også med det nye parameteret weight.
        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;
            //Her viser koden at så lenge weight er mindre enn 400 holder det med 8 hjul, men er den mer må man ha 12 hjul.

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        //Her endrer(overrider) vi metoden Describe() for denne klassen. Så når en innstanse av Truck.cs kaller på Describe printes det som står her.
        //Her kunne man lagt inn vekten, men det blir på en måte vist frem her allerede etter som at den har x antall Wheels etter vekten.
        //Forklaring fra docs.microsoft.com
        //The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

    }
}
