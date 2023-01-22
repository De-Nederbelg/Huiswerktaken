using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vervangtaak_Matthew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matthew van vught
            //21-01-2023
            //vervangtaak

            //velden
            string[] leerlingen = new string[15];
            byte _keuzemenu = 0;
            byte _mee = 0;
            Boolean _exit = false;

            //programma
            do
            {
                try
                {
                    //intro en keuzemenu
                    Console.Clear();
                    Console.WriteLine($"Welkom in mijn programma wat wilt u doen.\n1) alle leerlingen ingeven\n2) Namen van de leerlingen die meegaan laten zien.\n3) Leerling opzoeken\n4) Programma afsluiten.\n5) Friet bestellen.");
                    _keuzemenu = byte.Parse(Console.ReadLine());

                    if (_keuzemenu == 1)  //keuze 1 nieuwe leerlingen ingeven
                    {
                        //intro keuze 1
                        Console.Clear();
                        Console.WriteLine($"U wilt dus alle leerlingen die meegaan ingeven.");

                        //vragen hoeveel er mee gaan
                        Console.Write($"Hoeveel leerlingen gaan er mee: ");
                        _mee = byte.Parse(Console.ReadLine());

                        //for loop array ingeven
                        for (int i = 0; i < _mee; i++)
                        {
                            Console.Clear();
                            Console.Write($"Geef de naam van leerling {(i + 1).ToString()} die meegaat op uitstap: ");
                            leerlingen[i] = Console.ReadLine();
                        }

                    }
                    else if (_keuzemenu == 2) //namen leerlingen weergeven
                    {
                        Console.Clear();
                        Console.WriteLine($"Dit zijn de leerlingen die in het systeem zitten");
                        for (int i = 0; i < leerlingen.Length; i++)
                        {
                            if (leerlingen[i] != null) //als waarde aanwezig naam weergeven
                            {
                                Console.WriteLine(leerlingen[i]);
                            }
                            else //als geen waarde leeg weergeven
                            {
                                Console.WriteLine($"Leeg");
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (_keuzemenu == 3) // 1 specifieke leerling opzoeken
                    {
                        Console.Clear();
                        if (_mee != 0) // nakijken of er al leerlingen zijn ingegeven
                        {
                            //intro keuze 3
                            Console.WriteLine($"U wilt dus nakijken of een specifieke leerling meegaat op uitstap.\n");
                            Console.Write($"Geef de naam van de leerling die u zoekt: ");
                            string name = Console.ReadLine();

                            //nakijken of leerling in array staat
                            if (leerlingen.Contains(name)) 
                            {
                                Console.WriteLine($"Deze leerling is mee op uitstap.\nDruk op een toets om terug naar het menu te gaan.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"Deze leerling gaat niet mee op uitstap.\nDruk op een toets om terug naar het menu te gaan.");
                                Console.ReadKey();
                            }
                        }
                        else // respons in geval dat er nog geen leerlingen zijn ingegeven
                        {
                            Console.WriteLine($"U hebt nog geen leerlingen ingevoerd.\nDruk op een toets en kies optie 1 in het menu om leerlingen in te geven.");
                            Console.ReadKey();
                        }

                    }
                    else if (_keuzemenu == 4) // afsluiten programma
                    {
                        Console.Clear();
                        Console.WriteLine($"Het programma wordt afgesloten.\nDruk op een toets om af te sluiten.");
                        Console.ReadKey();
                        _exit = true;
                    }
                    else if (_keuzemenu == 5) //extra joke
                    {
                        Console.Clear();
                        Console.WriteLine($"Ik weet niet waarom u hier voor friet vraagt maar dit kunnen we niet, zou zowiso een dom idee zijn.\nDruk maar gewoon op een toets om terug naar het menu te keren en normaal te doen. :)");
                        Console.ReadKey();
                    }
                    else //extra foutbehandeling 
                    {
                        Console.Clear();
                        Console.WriteLine($"U heeft een nummer ingegeven maar jammer genoeg was deze geen optie.\nDruk op een toets en probeer aub opnieuw.");
                        Console.ReadKey();
                    }
                }
                catch //foutbehandeling
                {
                    Console.Clear();
                    Console.WriteLine("Sorry u hebt blijkbaar een fout nummer ingegeven druk op een toets en probeer aub opnieuw.");
                    Console.ReadKey();
                }
            }while (_exit != true); 
        }
    }
}
