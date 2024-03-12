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

// FUNKCJE - ARGUMENTY

MojaFunkcja(" H E L L O   W O R L D! ", 5);

static void MojaFunkcja(string tekst, int ileRazy)  // funkcja wieloargumentowa - wyświetli 5 razy napis " H E L L O   W O R L D!"
{
    for (int i = 0; i < ileRazy; i++)
    {
        Console.WriteLine(tekst);
    }
}

//==============================================================//



