//// Instrukcje warunkowe - If, ELSE IF, ELSE

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

//==============================================================//

// skrócony wyrażenia warunkowe - robi to samo co if{} i else{}
// operator trójwarunkowy
Console.WriteLine("Podaj liczbę:");
int num = int.Parse(Console.ReadLine());

string result = num % 2 == 0 ? "Parzysta" : "Nieparzysta";
Console.WriteLine(result);

//==============================================================//

