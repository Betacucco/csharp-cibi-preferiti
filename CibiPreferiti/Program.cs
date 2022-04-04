string[] cibiPreferiti = { "Carne", "Pizza", "Banane", "Lasagne", "Cannelloni", "Cioccolato Fondente", "Sushi", "Risotti", "Formaggi" };
Console.WriteLine("La mia classifica ha: " + cibiPreferiti.Length + " elementi");

//Stampiamo gli elementi e la loro posizione
Console.WriteLine("I nomi dei cibi in classifica sono:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine( (i + 1) + " - " + cibiPreferiti[i]);
}
//Stampiamo gli elementi top e bottom della classifica 
Console.WriteLine("Il mio cibo preferito in assoluto e': " + cibiPreferiti[0]);
Console.WriteLine("il cibo tra i preferiti che prediligo di meno e': " + cibiPreferiti[cibiPreferiti.Length - 1]);

//Ci servira' a stampare le posizioni al centro dell'array
int mediana = (cibiPreferiti.Length / 2);

//Se la lunghezza e' pari stampa il contenuto a meta' classifica, altrimenti stampa quello a meta' classifica e il successivo
if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("I miei cibi preferiti al centro sono: " + cibiPreferiti[(mediana - 1)] + " " + cibiPreferiti[mediana]);
}
else
{
    Console.WriteLine("Il mio cibo preferito al centro e': " + cibiPreferiti[mediana]);
}