using System;

namespace LearnInheritance
{
    /*
    Denne klassen arver fra Vehicle.cs. Når vi jobber med arv har vi to kategorier på klassene:
    Derived Class (child) - the class that inherits from another class.
    Base Class (parent) - the class being inherited from.
    I dette prosjektet blir Vehicle (parent) og Bicycle (child).
    For å arve og eller implementere bruker man ":" kolon.
     */
    class Bicycle : Vehicle
    {
        //Bicycle har sin egen konstuktør som vi kan instansiere fra. Den har også speed som parameter likt som base klassen (Vehicle.cs).
        //base er konstruktoren til vehicle.
        public Bicycle(double speed) : base(speed)
        {
            //Her setter vi verdien Wheels til 2. Wheels hører til Vehicle.cs for det er der den er deklarert.
            Wheels = 2;
        }

        //Dette er en metode for å øke farten, eller verdien på Speed som er det den faktisk gjør.
        //Her bruker vi "override" for å endre en "virtual" metode.
        public override void SpeedUp()
        {
            //Øker helt enkelt veriden(i dette tilfellet farten) med 5.
            Speed += 5;

            //Men har lagt inn at hvis farten blir høyere enn 15 så forblir den på 15.
            if (Speed > 15)
            {
                Speed = 15;
                //Her er en enkel linje som forteller at sykkelen ikke går fortere.
                Console.WriteLine($"Max speed for bike is {Speed} km/h.");
            }
        }

        //SlowDown() fungerer på samme måte som SpeedUp() over her, men har ikke med en melding som blir printet når den går i 0.
        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        //Her endrer(overrider) vi metoden Describe() for denne klassen. Så når en innstanse av Bicycle.cs kaller på Describe printes det som står her, da mer serial number på sykkelen i stedet for skiltnummer.
        //Forklaring fra docs.microsoft.com
        //The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        public override string Describe()
        {
            return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with serial number {LicensePlate}.";
        }

    }
}
