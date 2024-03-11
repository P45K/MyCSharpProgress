//==============================================================//

// DZIEŃ 1 i 2 - PRAKTYKA
// ŚREDNIA ARYTMETYCZNA

float a;    // przechowywane wartości od użytkownika (liczby wpisuywane przez użytkownika)    
float sum = 0;  // suma podanych liczb, aż program nie napotka 0 (gdy użytkownik wpisze 0);
int i = 0;  // ile liczb podał użytkownik

do
{
    Console.Write("Podaj liczbę: ");
    a = float.Parse(Console.ReadLine());
    if (a == 0) // ta pętla odejmie "0" od ilości podanych liczb
    {
        break;  // instrukcja skoku przerywająca pętlę
    }
    sum += a;
    i++;
} while (a != 0);   // warunek kontynuacji pętli (a musi być różne od 0, żeby pętla się wykonywała)

Console.WriteLine("Średnia arytmetyczna to: {0}", sum / i);


//==============================================================//
