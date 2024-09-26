// See https://aka.ms/new-console-template for more information

// NAME: Savanna Dickie DATE: 09/22/2024 LAB: Lab 2 Game of Sticks

using System;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Security;

Console.WriteLine(" ---- WELCOME TO THE GAME OF STICKS! ---- ");
Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks. \nThe player that removes the last stick loses.");


int player = 1;
int sticksLeft = 20;
int maxsticks = 3;

while(sticksLeft > 0) //loop until 0

{
    
    Console.WriteLine($"Sticks Left = {sticksLeft}");
    Console.WriteLine($"Player {player}, how many sticks would you like to choose?");

    string response = Console.ReadLine(); // user enters sticks
    int a; //erased Convert.IntTry32
    Console.Clear();
    
    while (!int.TryParse(response, out a) || a < 1 || a > 3) 
    {
        Console.WriteLine($"The maximum amount of sticks you can \nchoose are {maxsticks}. Please choose 1, 2, or 3. "); //step 8 ERROR message answer for bool
        response = Console.ReadLine();
        Console.Clear();
        continue;
    }

    sticksLeft = sticksLeft - a; // (subtracting sticks left by user answer)
    
    if (player == 1) 
    {
        player = 2;  
    }

    else
    {
        player = 1;
    }

    if(sticksLeft == 1)
    {
        Console.WriteLine("Please choose at least 1");
    }

    if(sticksLeft == 0 || sticksLeft < 0) 
    {
        Console.WriteLine($"yay! Player {player} won! GAME OVER");
        break;
    }
      
}

/*Console.WriteLine(" ---- WELCOME TO THE GAME OF STICKS! ---- ");

Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks. \nThe player that removes the last stick loses.");

Console.WriteLine("Sticks left:||||||||||||||||||||");
i
while (firstround< 3);
Console.WriteLine("Player 1, how many sticks would you like to take?");

string a = Console.ReadLine();
int firstRound = Convert.ToInt32(a);
int FirstRoundResults = 20 - firstRound; 
while(firstRound<= 3)
{
    
    Console.WriteLine($"Sticks Left: {FirstRoundResults} ");
    
    
}

Console.WriteLine("Player 2, how many sticks would you like to take?");
string b = Console.ReadLine();
int secondRound = Convert.ToInt32(b);
int SecondRoundResults = FirstRoundResults - secondRound;
Console.Clear(); */



/*Console.WriteLine(" ---- WELCOME TO THE GAME OF STICKS! ---- ");

Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks. \nThe player that removes the last stick loses.");

Console.WriteLine("Sticks left: 20");

Console.WriteLine("Player 1, how many sticks would you like to take?");
{
int sticksleft = 20;
string a = Console.ReadLine();


int firstRound = Convert.ToInt32(a);

int FirstRoundResults = 20 - firstRound; 
    if (firstRound<= 3)
    {

        Console.WriteLine($"Sticks left: {FirstRoundResults}");
        Console.WriteLine("Player 2, how many sticks would you like to take?");
        string b = Console.ReadLine();
        int secondRound = Convert.ToInt16(b);
        int SecondRoundResults = FirstRoundResults - secondRound;
        Console.WriteLine($"Sticks Left: {SecondRoundResults}");
        Console.WriteLine("Player 1, How many sticks would you like to take?");
        string c = Console.ReadLine();
        int thirdRound = Convert.ToInt16(c);
        int thirdRoundResults = SecondRoundResults - thirdRound;
        Console.WriteLine($"Sticks left: {thirdRoundResults}");
        Console.WriteLine("Player 1, how many sticks would you like to take?");

        string d = Console.ReadLine();
        int fourthRound = Convert.ToInt32(d);
        int fourthRoundResults = thirdRoundResults - fourthRound;
        Console.WriteLine($"Sticks left: {fourthRoundResults}");

        Console.WriteLine("Player 2, how many sticks would you like to take?");


    }


    if (firstRound> 3)
    {

        Console.WriteLine("Try again, Pick a number between 1 and 3. ");
        string c = Console.ReadLine();
        int firstRound2 = Convert.ToInt32(c);
        int firstRound2Results = 20 - firstRound2;
        Console.WriteLine($"Sticks left: {firstRound2Results}");
    }


}
      */

/*    string PlayerOne = "Player 1";
    int a = Convert.ToInt32(PlayerOne);
    int sticksleft = 20;
    int input = 3; 



while () */
/*
Console.WriteLine(" ---- WELCOME TO THE GAME OF STICKS! ---- ");

Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks. \nThe player that removes the last stick loses.");
string a = user; 
int a = Convert.ToInt32(user);
int sticksLeft = 20;
Console.WriteLine($"Sticks left: {sticksLeft} \n "); */


// STEP ONE explain the rules

/*Console.WriteLine(" ---- WELCOME TO THE GAME OF STICKS! ---- ");
Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks. \nThe player that removes the last stick loses.");

//step two and three and four
int player = 1;
int sticksLeft = 20;
int maxsticks = 3;

while(sticksLeft > 0) //loop until 0

{
    
    Console.WriteLine($"Sticks Left = {sticksLeft}");
    Console.WriteLine($"Player {player}, how many sticks would you like to choose?");

    string response = Console.ReadLine(); //step 6 user enters sticks
    int a; //erased Convert.IntTry32
    Console.Clear();

    while (!int.TryParse(response, out a) || a < 1 || a > 3) //step 7 if they take more than 3 

    {
        Console.WriteLine($"The maximum amount of sticks you can \nchoose are {maxsticks}. Please choose 1, 2, or 3. "); //step 8 ERROR message answer for bool
        response = Console.ReadLine();
        Console.Clear();
        continue;
    }

    // erased int sticksLeft = sticksleft - response
    sticksLeft -= a; //step 5 max sticks equal sticks left (subtracting sticks left by user answer)
    
    if (player == 1) //STEP 3 establish player 1
    {
        player = 2;
        
    }
    else
    {
        player = 1;
    
    }
    if(sticksLeft == 0) //step 10
    {
        player = player == 1 ? 2 : 1; //step 9
        Console.WriteLine($"YAY! Player {player} won! GAME OVER");
        break;
    }
      
} /*

/*while(sticksLeft == 0)
{
    if(player == 1);
    {
    Console.WriteLine($"Player {player} won the game!");
    }
    else if 
    {
        player = player == 1 ? 2 : 1;
    }
} */
