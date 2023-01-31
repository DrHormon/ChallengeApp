// Zadanie: Obliczenie częstości występowania znaków w podanej zmiennej
// pierwotnie określonej jako liczba typu integer 4456. To zostawiłem dla siebie "int number = 4456;"

// Zamiast stosować zmienną typu int zastosowałem zmienną typu string. W końcu i tak problemem
// jest policzenie częstości występowania znaków. Sposób konwersji zapamiętałem. Liczba mają ograniczenie długości
// zmienne typu string chyba nie. Chyba bo nie sprawdzałem.

// Podanie analizowanej zmiennej
string number = "88888888888876543";

//Zdeklarowanie liczników dla każdej z występujących cyfr.
var zerocounter = 0;
var onecounter = 0;
var twocounter = 0;
var threecounter = 0;
var fourcounter = 0;
var fivecounter = 0;
var sixcounter = 0;
var sevencounter = 0;
var eightcounter = 0;
var ninecounter = 0;

// Ponieważ zdeklarowałem analizowaną liczbę jako string to nie muszę konwertować liczby na string.
// string numberAsString = number.ToString();
// Pewnie mógłbym użyć zmiennej number zamiast numberAsString, ale tak jest czytelniej.

string numberAsString = number;
char [] letters = numberAsString.ToArray();

// Ciekaw jestem czy ktoś czyta kod.
// Pytanie: Czy tekst w nawiasie foreach znajdujący się po char ""letter" określa sposób
// nazywania elementów tej tablicy? Czy mógłbym podać dowolnie wybrany?
// Czym jest literał i czym '' różni się od ""?

foreach (char letter in letters)
{
    if (letter == '0')
    {
        zerocounter++;
    }
    else if (letter == '1')
    {
        onecounter++;
    }
    else if (letter == '2')
    {
        twocounter++;
    }
    else if (letter == '3')
    {
        threecounter++;
    }
    else if (letter == '4')
    {
        fourcounter++;
    }
    else if (letter == '5')
    {
        fivecounter++;
    }
    else if (letter == '6')
    {
        sixcounter++;
    }
    else if (letter == '7')
    {
        sevencounter++;
    }
    else if (letter == '8')
    {
        eightcounter++;
    }
    else if (letter == '9')
    {
        ninecounter++;
    }

}
    
// WYpisanie obliczonych wyników. 
    Console.WriteLine("Podana liczba to:"+number);
    Console.WriteLine("0 - " + zerocounter); 
    Console.WriteLine("1 - " + onecounter);
    Console.WriteLine("2 - " + twocounter);
    Console.WriteLine("3 - " + threecounter);
    Console.WriteLine("4 - " + fourcounter);
    Console.WriteLine("5 - " + fivecounter);
    Console.WriteLine("6 - " + sixcounter);
    Console.WriteLine("7 - " + sevencounter);
    Console.WriteLine("8 - " + eightcounter);
    Console.WriteLine("9 - " + ninecounter);
