using System;

namespace LearnInheritance
{
    /*
    Denne klassen arver fra Vehicle.cs og implementerer fra IAutomobile.cs. Når vi jobber med arv har vi to kategorier på klassene:
    Derived Class (child) - the class that inherits from another class.
    Base Class (parent) - the class being inherited from.
    I dette prosjektet blir Vehicle (parent) og Sedan (child).
    For å arve og eller implementere bruker man ":" kolon. Denne klassen arver fra Vehicle.cs og implementerer fra IAutomobile som blir skilt av med "," komma.
     */
    class Sedan : Vehicle, IAutomobile
    {
        //Sedan har sin egen konstuktør som vi kan instansiere fra. Den har også speed som parameter likt som base klassen (Vehicle.cs).
        //base er konstruktoren til vehicle.
        public Sedan(double speed) : base(speed)
        {
            //Her setter vi verdien Wheels til 4. Wheels hører til Vehicle.cs for det er der den er deklarert.
            Wheels = 4;
        }

        //Her endrer(overrider) vi metoden Describe() for denne klassen. Så når en innstanse av Sedan.cs kaller på Describe printes det som står her.
        //Forklaring fra docs.microsoft.com
        //The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
