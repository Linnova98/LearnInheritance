using System;

namespace LearnInheritance
{
    /*Denne klassen er abstract og det er denne klassen vi skal arve fra i de andre klassene vi skal lage. Denne klassen inneholder alt det vi trenger av info for alle kjøretøyene i vår kode.
    Forklaring på abstract fra W3Schools.
    Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    */
    abstract class Vehicle 
    {
        //Her må vi da deklarere alle verdiene.
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        //Dette er konstruktoren til Vehicle(hovedklassen). Det viktige fra denne er at den må ha "speed" i parameteret, som man ser i de andre klassene også.
        public Vehicle(double speed)
        {
            //Speed blir da satt ut i fra tallet(double) som blir satt i parameteret.
            Speed = speed;
            //Her kaller vi på verktøyet vi fikk fra Tools klassen for å generere skiltnummer.
            LicensePlate = Tools.GenerateLicensePlate();
        }

        //Dette er en metode for å øke farten, eller verdien på Speed som er det den faktisk gjør.
        //Her bruker vi "virtual" fordi at en metode som er "virtual" kan man endre(override) ved bruk av "override" i de klassene som arver fra klassen vi har "virtual" i.
        public virtual void SpeedUp()
        {
            //Øker helt enkelt veriden(i dette tilfellet farten) med 5.
            Speed += 5;
        }

        //Denne metoden fungerer helt likt som SpeedUp(), men i stedet synker veriden/farten med 5.
        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        //Dette er en metode som når den blir kalt bare printer ut HONK! (Den blir riktig nok ikke kalt i programmet nå, men var med i koden fra Codecademy)
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        //Forklaring på abstract fra W3Schools.
        //Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
        //Så denne metoden er tom her i hovedklassen, og forskjellig i hver av de andre klassene.
        public abstract string Describe();

    }
}