using System;

namespace LearnInheritance
{
    //Denne klassen er abstract og det er denne klassen vi skal arve fra i de andre klassene vi skal lage. Denne klassen inneholder alt det vi trenger av info for alle kjøretøyene i vår kode.
    //Forklaring på abstract fra W3Schools.
    //Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    abstract class Vehicle 
    {
        //Her må vi da deklarere alle variablene
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        //Dette er konstruktøren til Vehicle(hovedklassen). Det viktige fra denne er at den må ha "speed" i parameteret, som man ser i de andre klassene også.
        public Vehicle(double speed)
        {
            //Speed blir da satt ut i fra tallet(double) som blir satt i parameteret.
            Speed = speed;
            //Her kaller vi på verktøyet vi fikk fra Tools klassen for å generere skiltnummer.
            LicensePlate = Tools.GenerateLicensePlate();
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public abstract string Describe();

    }
}
