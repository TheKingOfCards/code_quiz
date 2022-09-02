string pText = "";
int points = 0;
int questions = 0;

Console.WriteLine("Welcome to code quiz");
Console.WriteLine("Get 3 or more answers correct to win");
Console.WriteLine("Type 1, 2 or 3 to answer");
Console.WriteLine("Write enter to begin");


while(pText != "enter"){    
pText = Console.ReadLine();
    if (pText != "enter"){
        Console.WriteLine("I said type \"enter\"");
    }
}

Console.Clear();
//First question
while(questions != 1){
    Console.WriteLine("First question");
    Console.WriteLine("What can an int variabel store?");
    Console.WriteLine("1:Text\n2:Numbers\n3:Pictures");
    pText = Console.ReadLine();
    if(pText == "2"){
        points++;
        questions++;
    }
    if(pText == "1" || pText == "3"){
        questions++;
    }
}

while(questions != 2){
    Console.WriteLine("Second question");
    pText = Console.ReadLine();
    
}


Console.ReadLine();