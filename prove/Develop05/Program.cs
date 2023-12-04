// Goal Tracker Program
// CSE 210
// The Earthworms 
// Contributers: Zach McLaughlin, Tarin James, Austin Jones
// A program that allows the user to create a goal and keep of their progress. 
// The program includes a point system to increase the engagement of the user.
// The user is able to create a simple, eternal, or checklist goal, and each track the goal differently.
// We exceeded expectations by creating a new goal called Long Term Goal, creates a goal with a 
// name, description, and date the user wants it completed by.

using System;
using System.Collections.Generic;


class Program
{
    //DESCRIPTION CANT HAVE COMMAS AND : OR ELSE ILL CRY
    static void Main(string[] args)
    {   
        Menu menuCall = new Menu();
        menuCall.runMenu();
    }
}