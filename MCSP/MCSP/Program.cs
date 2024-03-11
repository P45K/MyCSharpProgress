﻿//// INSTRUKCJE WARUNKOWE - If, ELSE IF, ELSE

//Console.WriteLine("Ile masz lat?");
//int wiek = int.Parse(Console.ReadLine());

//if (wiek >= 18)
//{
//    Console.WriteLine("Jesteś pełnoletni" + " Masz: " + wiek + " lat");
//}
//else
//{
//    Console.WriteLine("Nie jesteś pełnoletni");
//    Console.WriteLine("Przykro mi");
//}

//Console.WriteLine("Podaj liczbę:");
//int number = int.Parse(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("Liczba większa od 0");
//}
//else if (number < 0)
//{
//    Console.WriteLine("liczba jest mniejsza od zera");
//}
//else 
//{
//    Console.WriteLine("Liczba równa 0");
//}

////==============================================================//

//// SKRÓCONE WYRAŻENIA WARUNKOWE - robi to samo co if{} i else{}
//// OPERATOR TRÓJWARUNKOWY

//Console.WriteLine("Podaj liczbę:");
//int num = int.Parse(Console.ReadLine());

//string result = num % 2 == 0 ? "Parzysta" : "Nieparzysta";
//Console.WriteLine(result);

////==============================================================//

//// INSTRUKCJA WYBORU - SWITCH

//Console.WriteLine("Podaj dzień tygodnia (liczbowo od 1 do 7)");
//int dniTygodnia = int.Parse(Console.ReadLine());

//switch (dniTygodnia)
//{
//    case 1: // "case" zawsze sprawdza == 
//        Console.WriteLine("Poniedziałek");
//        break;
//    case 2:
//        Console.WriteLine("Wtorek");
//        break;
//    case 3:
//        Console.WriteLine("Środa");
//        break;
//    case 4:
//        Console.WriteLine("Czwartek");
//        break;
//    case 5:
//        Console.WriteLine("Piątek");
//        break;
//    case 6:
//    case 7:
//        Console.WriteLine("Weekend");
//        break;
//    default:
//        Console.WriteLine("Nie ma takiego dnia tygodnia!");
//        break;
//}

////
//Console.WriteLine("Podaj kolor samochodu:");
//string kolorSamochodu = Console.ReadLine(); 
//string marka; 
//switch (kolorSamochodu) 
//{ 
//    case "czerwony": 
//        marka = "Ferrari"; 
//        break; 
//    case "niebieski": 
//        marka = "Ford"; 
//        break; 
//    case "czarny": 
//        marka = "Nissan"; 
//        break;
//    case "zielony":
//        marka = "Toyota";
//        break;
//    default: 
//        marka = "Nieznana"; 
//        break; 
//}

//Console.WriteLine("Marka samochodu o kolorze {0} to {1}.", kolorSamochodu, marka);

////==============================================================//

//// PĘTLA - WHILE

//Console.Write("Podaj liczbę:");
//int a = int.Parse(Console.ReadLine());

//int i = 1; // wg konwencji od literki "i" zaczynają sie nazwy zmiennych pomocniczych

//while (i <= a) 
//{
//    Console.WriteLine(i);
//    i++;
//}


////==============================================================//

//// PĘTLA - DO WHILE
//// - różnica między WHILE a DO WHILE jest taka, że jeśli warunek nie zostanie spełniony, to pętla WHILE nie uruchomi się a DO WHILE wykona się przynajmniej jeden raz

//Console.Write("Podaj liczbę: ");

//int b = int.Parse(Console.ReadLine());

//int j = 1; // wg konwencji od literki "i" zaczynają sie nazwy zmiennych pomocniczych

//Console.WriteLine("While");
//while (j <= b)
//{
//    Console.WriteLine(j);
//    j++;
//}

//Console.WriteLine("Do While");
//j = 1;

//do
//{
//    Console.WriteLine(j);
//    j++;
//} while (j <= b);

//// === PROGRAMIK PODAJ WIEK > 0, < 100 === //

//int wiek = 0;   // jeśli użytkownik wprowadzi wiek mniejszy od zera (np -1) i większy od 100 (np 101), to program wykonapętlę ponownie.

//do
//{
//    Console.WriteLine("Wprowadź wiek większy od zera, ale mniejszy od 100:");
//    wiek = Convert.ToInt32(Console.ReadLine());
//} while (wiek <= 0 || wiek >= 100);


////==============================================================//


//// PĘTLA - FOR

//Console.WriteLine("Podaj liczbę: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//for ( int i = 1; i <= a; i++) // gdzie: (i = 1;) - delklaracja zmiennej pomocniczej, (i <= a;) - warunek wykonania petli, (i++) - instrukcja, która zostanie wykonana na końcu petli aż do wykonania warunku pętli
//{
//    Console.WriteLine(i);
//}

//// PĘTLA - FOR EACH
//// FOR EACH - TO PETLA OBIEKTOWA i NIE DZIAŁA W KONTEKŚCIE DLA POJEDYŃCZEJ LICZBY.

//Console.WriteLine("Podaj tekst: ");
//string text = Console.ReadLine();

//foreach (char litera in text)
//{
//    Console.WriteLine(litera);
//}

//==============================================================//

// INSTRUKCJE SKOKU - BREAK i CONTINUE

//for (int i = 0; ; i++)  // pętla wykona sie do 20 i zakończy działanie
//{
//    if (i > 20) 
//    {
//        break;
//    }
//    if (i % 2 == 1) // warunek sprawdza czy liczba jest nieparzysta, pętla wyświetli tylko wartości parzyste od 0 do 20
//    {
//        continue;
//    }
//    Console.WriteLine(i);
}

//==============================================================//

// INSTRUKCJA SKOKU - GOTO

    int i = 0;
hello:  // etykieta "hello:"
    Console.WriteLine("Hello");
    i++;

    if(i < 10)
        goto hello; // program wraca do lini z etykietą "hello:"


//==============================================================//
