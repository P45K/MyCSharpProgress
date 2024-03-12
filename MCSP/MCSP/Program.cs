////==============================================================//

////  === FUNKCJE ===

//    // FUNKCJE BEZARGUMENTOWE

//    /* - FUNKCE TWORZYMY BEZPOŚREDNIO W KLASIE
//       - FUNKCJE MUSZĄ BYĆ ZAKOŃCZONE NAWIASAMI ()
//       - W NAWIASACH () ZNAJDUJĄ SIĘ ARGUMENTY FUNKCJI
//       - FUNKCJA POSIADA CIAŁO W NAWIASACH {}
//       - FUNKCJĘ MOŻNA WYWOŁAĆ PO JEJ NAZWIE WIELE RAZY W RÓŻNYCH MIEJSCACH */

//HelloWorld();   // wywołanie funkcji
//HelloWorld();
//HelloWorld();
//HelloWorld();

//static void HelloWorld()    // funkcja bezargumentowa 
//{
//    Console.WriteLine("H E L L O   W O R L D!");
//}

//==============================================================//

//    // FUNKCJE - ARGUMENTY

//MojaFunkcja(" H E L L O   W O R L D! ", 5);

//static void MojaFunkcja(string tekst, int ileRazy)  // funkcja wieloargumentowa - wyświetli 5 razy napis " H E L L O   W O R L D!"
//{
//    for (int i = 0; i < ileRazy; i++)
//    {
//        Console.WriteLine(tekst);
//    }
//}

////==============================================================//

//    // FUNKCJE - ZWRACANIE WARTOŚCI


//int res = FunkcjaAdd(5, 10);
//Console.WriteLine(res);

//static int FunkcjaAdd(int a, int b) // funkcja typu int 
//{
//    int sum = a + b;
//    return sum; // return (słówko skoku) kończy, przerywa działanie funkcji i powinno być zawsze na końcu funkcji
//}

//    // prostsza wersja

//    //  Console.WriteLine(FunkcjaAdd2(5, 10));

//    //  static int FunkcjaAdd2(int c, int d)
//    //  {
//    //      return c + d;
//    //  }

//==============================================================//

// FUNKCJE - ARGUMENTY NAZWANE

MojaFunkcja(" H E L L O   W O R L D! ", 5);
MojaFunkcja(ileRazy: 5, tekst: "Hi");   // wywołanie funkcji z argumentami nazwanymi, daje nam możliwośc zamiany kolejności argumentów

static void MojaFunkcja(string tekst, int ileRazy)  // funkcja wieloargumentowa - wyświetli 5 razy napis " H E L L O   W O R L D!"
{
    for (int i = 0; i < ileRazy; i++)
    {
        Console.WriteLine(tekst);
    }
}

//==============================================================//