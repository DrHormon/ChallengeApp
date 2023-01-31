// Zadanie: Obliczenie częstości występowania znaków w podanej zmiennej
// pierwotnie określonej jako liczba typu integer 4456. To zostawiłem dla siebie "int number = 4456;"

// Zamiast stosować zmienną typu int zastosowałem zmienną typu string. W końcu i tak problemem
// jest policzenie częstości występowania znaków. Sposób konwersji zapamiętałem. Liczba mają ograniczenie długości
// zmienne typu string chyba nie. Chyba bo nie sprawdzałem.

// Podanie analizowanej zmiennej
string number = "88888888888876543";

//Zdeklarowanie liczników dla każdej z występujących cyfr.
var zeroCounter = 0;
var oneCounter = 0;
var twoCounter = 0;
var threeCounter = 0;
var fourCounter = 0;
var fiveCounter = 0;
var sixCounter = 0;
var sevenCounter = 0;
var eightCounter = 0;
var nineCounter = 0;

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
        zeroCounter++;
    }
    else if (letter == '1')
    {
        oneCounter++;
    }
    else if (letter == '2')
    {
        twoCounter++;
    }
    else if (letter == '3')
    {
        threeCounter++;
    }
    else if (letter == '4')
    {
        fourCounter++;
    }
    else if (letter == '5')
    {
        fiveCounter++;
    }
    else if (letter == '6')
    {
        sixCounter++;
    }
    else if (letter == '7')
    {
        sevenCounter++;
    }
    else if (letter == '8')
    {
        eightCounter++;
    }
    else if (letter == '9')
    {
        nineCounter++;
    }

}
    
// WYpisanie obliczonych wyników. 
    Console.WriteLine("Podana liczba to:"+number);
    Console.WriteLine("0 - " + zeroCounter); 
    Console.WriteLine("1 - " + oneCounter);
    Console.WriteLine("2 - " + twoCounter);
    Console.WriteLine("3 - " + threeCounter);
    Console.WriteLine("4 - " + fourCounter);
    Console.WriteLine("5 - " + fiveCounter);
    Console.WriteLine("6 - " + sixCounter);
    Console.WriteLine("7 - " + sevenCounter);
    Console.WriteLine("8 - " + eightCounter);
    Console.WriteLine("9 - " + nineCounter);
