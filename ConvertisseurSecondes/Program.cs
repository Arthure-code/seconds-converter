

// declaration de la  variable 'nombreSeconde' comme une variables de types double
double nombreSeconde;
const double joursAnnee = 365.25;
const double secondeMin = 60.0;
const double minHeure = 60.0;
const double heureJour = 24.0;

//Conversion d'une annee en seconde
double secondesAnnee = joursAnnee * heureJour * minHeure * secondeMin;

//Conversion d'un jour en seconde
double secondesJour = heureJour * minHeure * secondeMin;

//Conversion d'une heure en seconde
double secondesHeure = minHeure * secondeMin;

Console.Write("\n\n\n----------------------------  convertisseurSecondes  ---------------------------- \n\n\n\n\n\n ");

//demande a l'utilisateur d'entre un nombre
Console.Write("Entrez le nombre de secondes : ");

//La variable «input» pourra contenir des chaines de caractères ou etre null
string? input = Console.ReadLine();

/*verifie chaque fois que cette condition est vrai et si c'est le cas effectue les operation ci dessous
verifie si la condition suplementaire est toujours vrain et fais les calculs*/

if (double.TryParse(input, out nombreSeconde) && nombreSeconde >= 0)
{
    int Annes = (int)(nombreSeconde / secondesAnnee);
    nombreSeconde %= secondesAnnee;

    int jours = (int)(nombreSeconde / secondesJour);
    nombreSeconde %= secondesJour;

    int heurs = (int)(nombreSeconde / secondesHeure);
    nombreSeconde %= secondesHeure;

    int minutes = (int)(nombreSeconde / secondeMin);
    nombreSeconde %= secondeMin;

    int secondes = (int)nombreSeconde;

    // si la condition est verifie affiche le message ci dessous.
    Console.WriteLine($"\n\n\n\t{Annes} années, {jours} jours, {heurs} heures, {minutes} minutes, {secondes} secondes");
}
else
{   // dans le cas contraire affiche ce message
    Console.WriteLine("\n\n\n\t\t\t\t\t Entrée invalide. Veuillez entrer un nombre valide de secondes.");
}
