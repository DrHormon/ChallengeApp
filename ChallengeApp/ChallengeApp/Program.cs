
// komunikatPierwszy: "Kobiet poniżej 30 lat"
// komunikatDrugi: "Ewa, lat 33"
// "Niepełnoletni Mężczyzna"

var name = "Andrzej";
var sex = 'M';
var age = 120;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else         
{
    Console.WriteLine(name + " płeć M "+"wiek: " + age);
}