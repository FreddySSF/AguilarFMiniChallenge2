// Fernando Aguilar
// 10-18-22
// Mini Challenge 2 Add Two Numbers Endpoint
// Recreating Mini Challenge 2 where the user chooses two numbers.
// The program takes both inputs and adds them together. Adding data validation.
// Peer Reviewed By: Marcel Rodriguez - The program runs well. It has a replay function and data validation for ints. The instructions are clear so the right inputs are typed. Solid work!
    Console.Clear();

Console.WriteLine(" let's do some quick maths! we will be adding two numbers together! ");

bool replay = true;

    while(replay)
    {
        Console.WriteLine(" type your first number in..");
            bool trueNum1 = false;
            string firstNum;
            int num1 = 0;
        while(!trueNum1)
    {
        firstNum = Console.ReadLine();
        trueNum1 = Int32.TryParse(firstNum, out num1);
            if(!trueNum1)
        {
            Console.WriteLine(" that is not a number. please enter a number.. ");
        }
    }
        
        
        Console.WriteLine(" now type in your second number.");
            bool trueNum2 = false;
            string secondNum;
            int num2 = 0;
        while(!trueNum2)
    {
        secondNum = Console.ReadLine();
        trueNum2 = Int32.TryParse(secondNum, out num2);
            if(!trueNum2)
        {
            Console.WriteLine(" that is not a number. please enter a number.. ");
        }
    }
           

    Console.WriteLine( " the sum of your two numbers is " + (num1 + num2) + ", great work! that's quick maths! ");

        Console.WriteLine(" would you like to try again with different numbers? ");
        Console.WriteLine(" type yes to continue, or type no to end the program.. ");
            string tryAgain = Console.ReadLine();
    if(tryAgain.ToLower() == "no" || tryAgain.ToLower() == "n")
        {
          Console.WriteLine(" thank you for playing! have a great day! ");
          replay = false;
        }
    else if(tryAgain.ToLower() == "yes" || tryAgain.ToLower() == "y")
        {
            replay = true;
        }
    }