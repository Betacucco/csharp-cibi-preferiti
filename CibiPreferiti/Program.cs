string[] cibiPreferiti = { "Carne", "Pizza", "Banane", "Lasagne", "Cannelloni", "Cioccolato Fondente", "Sushi", "Risotti", "Formaggi" };
Console.WriteLine("La mia classifica ha: " + cibiPreferiti.Length + " elementi");

//La posizione ci servira' sia per numerare gli elementi dell'array sia per stampare gli elementi di meta' classifica
int posizione = 0;
Console.WriteLine("I nomi dei cibi in classifica sono:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    posizione = i;
    //Stampiamo gli elementi e la loro posizione
    Console.WriteLine( (posizione + 1) + " - " + cibiPreferiti[i]);
}
//Stampiamo gli elementi top e bottom della classifica 
Console.WriteLine("Il mio cibo preferito in assoluto e': " + cibiPreferiti[0]);
Console.WriteLine("il cibo tra i preferiti che prediligo di meno e': " + cibiPreferiti[8]);

//Se la lunghezza e' pari stampa il contenuto a meta' classifica, altrimenti stampa quello a meta' classifica e il successivo
if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("Il mio cibo preferito al centro e': " + cibiPreferiti[(posizione - 1) / 2]);
}
else
{
    Console.WriteLine("I miei cibi preferiti al centro sono: " + cibiPreferiti[(posizione -1) / 2] + " " + cibiPreferiti[posizione / 2]);
}