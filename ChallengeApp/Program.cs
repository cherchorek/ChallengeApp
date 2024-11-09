var name = "Ewa";
bool sexM = false; //sexM = true [mężczyzna], w przeciwnym wypadku kobieta
int age = 29;

if ((sexM != true) && (age < 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if ((name == "Ewa") && (age == 30))
{
    Console.WriteLine("Ewa, lat 30");
}
else if ((sexM == true) && (age < 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}