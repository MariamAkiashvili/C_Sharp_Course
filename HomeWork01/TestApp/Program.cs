//Task1 

using System.Collections.Generic;

int c = int.Parse(Console.ReadLine());


if(c < 0){
    Console.WriteLine("Cold");
}
else if (c < 30){
    Console.WriteLine("Good Wheather");
}
else {
    Console.WriteLine("Hot");
}




// TASK2

var rand = new Random();

List <string> options = new List <string>
{
    "Paper",
    "Scissors",
    "Rock"
};

Console.WriteLine("Choose one : Paper, Scissors or Rock");
string user = Console.ReadLine();
string comp = options[rand.Next(0,3)];
Console.WriteLine("Computer: " + comp);

if(("paper" == user.ToLower() && "Rock" == comp)
        || ("rock" == user.ToLower() && "Scissors" == comp) 
        || ("scissors" == user.ToLower() && "Paper" == comp)){
            Console.WriteLine("Yow Won");
        }
else if (("rock" == user.ToLower() && "Paper" == comp)
        || ("scissors" == user.ToLower() && "Rock" == comp) 
        || ("Paper" == user.ToLower() && "Scissors" == comp)){
            Console.WriteLine("You Lost");
        }

else {
    Console.WriteLine("Ooops!");
}






//Task3
Console.WriteLine("Enter Your Birth Year");
int year = int.Parse(Console.ReadLine());

List <string> years = new List <string> 
{
    "Rat","Ox","Tiger","Rabbit","Dragon","Snake","Horse","Sheep",
    "Monkey","Rooster","Dog","Pig"
};

if (year<2023){
    int res = ((year%12)+12-4)%12;
    Console.WriteLine(years[res]);
}else {
    int res = (3+((year-2023)%12))%12;
    Console.WriteLine(years[res]);
}

