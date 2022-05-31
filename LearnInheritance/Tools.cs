using System;
/*
Her er en pre-build tool fra Codecademy.com, men legger til en liten forklaring på denne også.
 */
namespace LearnInheritance
{
    static class Tools
    {
        //Alle karkaterene man kan ha i skiltnummeret i en string.
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateLicensePlate()
        {
            //Deklarering av Random variabelen. Som å skrive: var rand = x; bare at man bruker den innebygde klassen Random og kaller en instanse av den.
            Random rand = new Random();
            //Deklarert variabel for licenseplate som er tom for nå.
            string licensePlate = "";
            //For loop som går 8 ganger for å få en lisenceplate som har 8 tegn.
            for (int i = 0; i < 8; i++)
            {
                //Her legger man til en karater fra chars, og den er rand(random) hver gang.
                //Istedet for å telle hvor mange tegn det er i chars tar man Next(int) med chars.Length.
                //Da leser den max value til chars og returner det i en int til Next(int) så velger den random en karakter fra chars.
                //Next(int) = Returns a positive random integer that is less than the specified maximum value.
                licensePlate += chars[rand.Next(chars.Length)];
            }
            //Her returnerer man licensePlate etter at den har loopet 8 ganger for hver karakter.
            return licensePlate;
        }
    }
}
