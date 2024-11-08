var imie = "Ewa";
bool plecM = false; //plecM = true [mężczyzna], w przeciwnym wypadku kobieta
int wiek = 29;

if ((plecM != true) && (wiek < 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if ((imie == "Ewa") && (wiek == 30))
{
    Console.WriteLine("Ewa, lat 30");
}
else if ((plecM == true) && (wiek < 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}