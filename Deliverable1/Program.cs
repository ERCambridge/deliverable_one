
int sodaStock = 100;
int sodaRestock = 40;
int chipsStock = 40;
int chipsRestock = 20;
int candyStock = 60;
int candyRestock = 40;

Console.WriteLine("Welcome to the restocking tool.");

Console.WriteLine("How many sodas were sold today? " + sodaStock + " are in stock.");
int sodaSold = int.Parse(Console.ReadLine());
if (sodaSold > sodaStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted.");
}
else {
    sodaStock -= sodaSold;
    Console.WriteLine(sodaStock + " sodas remain.");
}

Console.WriteLine("How many chips were sold today? " + chipsStock + " are in stock.");
int chipsSold = int.Parse(Console.ReadLine());
if (chipsSold > chipsStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted.");
}
else
{
    chipsStock -= chipsSold;
    Console.WriteLine(chipsStock + " chips remain.");
}

Console.WriteLine("How many candies were sold today? " + candyStock + " are in stock.");
int candySold = int.Parse(Console.ReadLine());
if (candySold > candyStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted.");
}
else
{
    candyStock -= candySold;
    Console.WriteLine(candyStock + " candies remain.");
}

Console.WriteLine("Thank you for entering the values. Here's what needs to be restocked:");

if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked.");
}

if (chipsStock<= chipsRestock)
{
    Console.WriteLine("Chips need to be restocked.");
}

if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked.");    
}

if (sodaStock > sodaRestock &&  chipsStock > chipsRestock && candyStock > candyRestock)
{
    Console.WriteLine("Nothing needs to be restocked.");    
}