// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//var nimi = Console.ReadLine();
//if (nimi.ToUpper() == "JUKU")
//{
//    Console.WriteLine("lahme kinno");
//    int vanus = Convert.ToInt32(Console.ReadLine());
//    if (vanus < 0 || vanus > 120) //&& - and
//    {
//        Console.WriteLine("Vanus ei saa {0} olla", vanus);
//    }
//    else if (vanus < 6)
//    {
//        Console.WriteLine("Tasuta");
//    }
//    else if (vanus >= 6 && vanus < 14)
//    {
//        Console.WriteLine("lastepilet");
//    }
//    else if (vanus >= 14 && vanus < 65)
//    {
//        Console.WriteLine("täispilet");
//    }
//}
//else
//{
//    Console.WriteLine("Mind kodus pole");
//}
//Console.Clear();
//Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Blue;
Random rnd = new Random();
//int hinne = rnd.Next(1, 5);
//Console.WriteLine("Täna sai hinne{0}", hinne);
//string reaktsion = "";
//switch (hinne)
//{
//    case 1: reaktsion = "Õpi veel!"; break;
//    case 2: reaktsion = "Õpi natuke veel!"; break;
//    case 3: reaktsion = "Rahuldav!"; break;
//    case 4: reaktsion = "Hea tulemust!"; break;
//    case 5: reaktsion = "Väha hea!"; break;
//    default:
//        reaktsion = "Viga!";
//        break;
//}
//Console.WriteLine("FOR ABIL");
//for (int i = 0; i < hinne; i++)
//{
//    Console.WriteLine(reaktsion);
//}
//Console.WriteLine("WHILE ABIL");
//int hinne_test = hinne;
//while (hinne > 0)
//{
//    hinne--; //hinne=hinne-1
//    Console.WriteLine(reaktsion);
//}
//Console.WriteLine("DO WHILE ABIL");
//do
//{
//    Console.WriteLine(reaktsion);
//    hinne_test--;
//} while (hinne_test != 0);

//Console.Clear();
//var kommid = "";
//do
//{
//    Console.WriteLine("osta kommid");
//    kommid = Console.ReadLine();
//} while (kommid != "okei");





//Console.WriteLine("Tere, " + nimi);
//Console.WriteLine("Arv1: ");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Arv2: ");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tehe: ");
//char tehe = Convert.ToChar(Console.ReadLine()[0]);
//double vastus;
//if (tehe=='+')
//{
//    vastus = arv1 + arv2;
//}
//else if (tehe=='-')
//{
//    vastus = arv1 - arv2;
//}
//else if (tehe=='/')
//{
//    vastus = arv1 / arv2;
//}
//else
//{
//    Console.WriteLine(" {0} - tundmatu tehe", tehe);
//}
//Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, vastus);

//int kogus=rnd.Next(1,10);
//string[] Nimed = new string[kogus];
//string nimi = "";

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("Sisesta {0}. nimi: ", i+1);
//    nimi=Console.ReadLine();
//    Nimed[i] = nimi;
//}

//for (int i = 0; i < Nimed.Length; i++)
//{
//    Console.WriteLine("Tere {0}", Nimed[i]);
//}



for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write("{0,4}", i * j);
        }
        Console.WriteLine();
    }

//int katse = 0;
//int arvuti=rnd.Next(1, 100);
int inimene;
//do
//{
//    inimene = Convert.ToInt32(Console.ReadLine());
//    katse++;
//} while (inimene!=arvuti&& katse!=5);

int[] Arvud = new int[5];
for (int i = 0; i < 5; i++)
{
    Arvud[i] = Convert.ToInt32(Console.ReadLine());
}
int summa=0,korrutis=1;
double keskmine;
foreach (int arv in Arvud)
{
    Console.Write("{0,5}", arv);
    summa = summa + arv;
    korrutis = korrutis * arv;
}
keskmine= summa / Arvud.Length;
Console.WriteLine("\nSumma={0}, \nKorrutis={1}, \nKeskmine={2}", summa, korrutis, keskmine);
