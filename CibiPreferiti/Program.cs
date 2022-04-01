string[] cibiPreferiti = { "Carne", "Pizza", "Banane", "Lasagne", "Cannelloni", "Cioccolato Fondente", "Sushi", "Risotti", "Formaggi" };
Console.WriteLine("La mia classifica ha: " + cibiPreferiti.Length + " elementi");

Console.WriteLine("I nomi dei cibi in classifica sono:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}
Console.WriteLine("Il mio cibo preferito in assoluto e': " + cibiPreferiti[0]);
Console.WriteLine("il cibo tra i preferiti che prediligo di meno e': " + cibiPreferiti[8]);