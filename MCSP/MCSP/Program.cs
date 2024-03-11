//==============================================================//

// TABLICE JEDNOWYMIAROWE

// TABLICA ZAWSZE JEST JEDNEGO TYPU
// TABLICE SĄ Z GÓRY OKREŚLONEJ WARTOŚCI

// pierwszy sposób deklaracji tablicy jednowymiarowej
int[] tablica = new int[5]; // jedna zmienna przechwoująca 5 warrtości (5 szufladek) - 5 indeksów
tablica[0] = 1; // index 1
tablica[1] = 2;
tablica[2] = 3;
tablica[3] = 4;
tablica[4] = 5; // index 5

Console.WriteLine("Length: {0}", tablica.Length);

//  for (int i = 0; i < 5; i++)    // pętla na sztywno - ma się wykonywac daną ilośc razy
for (int i = 0; i < tablica.Length; i++)    // pętla dynamiczna
{
    Console.WriteLine(tablica[i]);
}

Console.WriteLine();

// drugi sposób deklaracji tablicy jednowymiarowej
char[] tablica2 = { 'H', 'E', 'L', 'L', 'O' };  // tablica zawierająca 5 wypełnionych indeksów

foreach (char litera in tablica2) 
{
    Console.WriteLine(litera);
}

//==============================================================//
