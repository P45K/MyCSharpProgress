////==============================================================//

//// TABLICE JEDNOWYMIAROWE

//// TABLICA ZAWSZE JEST JEDNEGO TYPU
//// TABLICE SĄ Z GÓRY OKREŚLONEJ WARTOŚCI

//// pierwszy sposób deklaracji tablicy jednowymiarowej
//int[] tablica = new int[5]; // jedna zmienna przechwoująca 5 warrtości (5 szufladek) - 5 indeksów
//tablica[0] = 1; // index 1
//tablica[1] = 2;
//tablica[2] = 3;
//tablica[3] = 4;
//tablica[4] = 5; // index 5

//Console.WriteLine("Length: {0}", tablica.Length);

////  for (int i = 0; i < 5; i++)    // pętla na sztywno - ma się wykonywac daną ilośc razy
//for (int i = 0; i < tablica.Length; i++)    // pętla dynamiczna
//{
//    Console.WriteLine(tablica[i]);
//}

//Console.WriteLine();

//// drugi sposób deklaracji tablicy jednowymiarowej
//char[] tablica2 = { 'H', 'E', 'L', 'L', 'O' };  // tablica zawierająca 5 wypełnionych indeksów

//foreach (char litera in tablica2) 
//{
//    Console.WriteLine(litera);
//}

////==============================================================//

//// TABLICE WIELOWYMIAROWE

//// pierwszy sposób deklaracji tablicy wielowymiarowej (tutaj 2 wymiary)
//int[,] tablicaWieloWymiar = new int[2, 3];
//tablicaWieloWymiar[0, 0] = 1;
//tablicaWieloWymiar[1, 2] = 9;

//Console.WriteLine(tablicaWieloWymiar[0, 0]);
//Console.WriteLine(tablicaWieloWymiar[1, 2]);
//Console.WriteLine("\nWymiary");
//Console.WriteLine(tablicaWieloWymiar.Length);   
//Console.WriteLine(tablicaWieloWymiar.GetLength(0)); // wyświetla pierwszy wymiar
//Console.WriteLine(tablicaWieloWymiar.GetLength(1)); // wyświetla drugi wymiar

//Console.WriteLine("\nWymiary");

//// dla tablicy dwówymiarowej jedno zagnieżdżenie pętli for, dla trzywymiarowej dwa zagnieżdżenia itd...
//for (int i = 0; i < tablicaWieloWymiar.GetLength(0); i++)   // pętla zewnętrzna przechodzi (iteruje) przez wszystkie wiersze tablicy
//{
//    for (int j = 0; j < tablicaWieloWymiar.GetLength(1); j++)   // petla wewnętrzna przechodzi przez wszystkie kolumny tablicy
//    {
//        Console.Write(tablicaWieloWymiar[i, j] + " ");  // wyświetlenie wszystkich wierszy i kolumn z wartościami(wymiarów)
//    }
//    Console.WriteLine();
//}

//// tablica 3 wymiarowa
//Console.WriteLine("\ntab3Wymiar: ");

//int[,,] tab3wymiar = new int[2, 2, 2];
//tab3wymiar[ 0, 1, 0 ] = 9;
//Console.WriteLine(tab3wymiar[ 0, 1, 0 ]);

//Console.WriteLine("\nTekstowa Tablica");
//// drugi sposob deklaracji tablicy wielowymiarowej (tutaj dwa wymiary) 
//string[,] tabTekstowa2d = { { "Hello", "World" }, { "Witaj", "Świecie" } };

//Console.WriteLine(tabTekstowa2d[0,0] + " " + tabTekstowa2d[0,1]);
//Console.WriteLine(tabTekstowa2d[1,0] + " " + tabTekstowa2d[1,1]);

//Console.WriteLine("\nForeach");
//// zastosowanie pętli (foreach)
//foreach (var item in tabTekstowa2d)
//{
//    Console.WriteLine(item);
//}


//==============================================================//

// TABLICE TABLIC - tablice wyszczerbione
// główna różnica między tablicami wielowymiarowymi, a tablicami tablic jest to, że w tablicach tablic można zadeklarować różną ilość kolumn w każdym wierszu
int[][] tabTablic = new int[3][];
tabTablic[0] = new int[4];  // 1 indeks
tabTablic[1] = new int[6];  // 2 indeks
tabTablic[2] = new int[8];  // 3 indeks (ostatni indeks pierwszej tablicy)

tabTablic[0][0] = 1;
tabTablic[2][7] = 9;    // gdzie: [2] - to 3 indeks(ostatni) indeks pierwszej tablicy, [7] to ostatni dostępny indekst drugiej tablicy (0,1,2,3,4,5,6,7)=[8]

Console.WriteLine(tabTablic[0][0]);
Console.WriteLine(tabTablic[2][7]);

Console.WriteLine("\nFor");
// przykład uzycia petli FOR dla tablicy tablic
for (int i = 0; i < tabTablic.Length; i++)
{
	for (int j = 0; j < tabTablic[i].Length; j++)
	{
        Console.Write(tabTablic[i][j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("/nForeach");
// przykład użycia petli FOREACH dla tablicy tablic
foreach (int[] tablica in tabTablic)
{
	foreach (int element in tablica)
	{
        Console.Write(element + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("\nTablica Punkty");
// drugi sposob zapisu z użyciem petli FOR
int[][] punkty = new int[3][];

punkty[0] = new int[] { 1, 2 }; // punkt (1, 2)
punkty[1] = new int[] { 3, 4, 5 }; // punkt (3, 4, 5)
punkty[2] = new int[] { 6 }; // punkt (6)

for (int k = 0; k < punkty.Length; k++)
{
    for (int l = 0; l < punkty[k].Length; l++)
    {
        Console.Write(punkty[k][l] + " ");
    }
    Console.WriteLine();
}


//==============================================================//