namespace LearnInheritance
{
    /*
     Her er et enkelt interface som det er mer om i interface koden jeg og har lagt ut. Med få ord kan jeg si at det er en slags
    arbeidstegning for de klassene som implementerer den, som forklarer hva som er i klassen helt enkelt med type/metode type og navnet.
    Har du klasser med store metoder er det lettere å få en oversikt over hva som er i klassen med å lese denne lille infoen fra interfacet.
     */
    interface IAutomobile
    {
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
}