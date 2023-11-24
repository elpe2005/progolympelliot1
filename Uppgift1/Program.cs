using System;

Console.WriteLine("Skriv in ett ord sen efter det skriv in hur många gånger du vill repetera det, max 9 gånger.");
string ogstring = Console.ReadLine();
Console.Write("Skriv in hur många gånger ");
int repetera = Convert.ToInt32(Console.ReadLine());
string repeterad = Console.ReadLine();
if (ogstring.Length <= 9){
    if (repetera <= 9){
        for (int i = 0; i < repetera; i++){
        repeterad += ogstring;
        }
        }
        else{
            Console.WriteLine("Inte repetera mer än 9 gånger!");
        }
        }
        else{
            Console.WriteLine("Ditt ord får inte innehålla mer än 9 bokstäver");
        }
        Console.WriteLine(repeterad);
        Console.ReadKey();
    