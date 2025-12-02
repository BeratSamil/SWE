
using System;
class GuessTheNumber
{

    static int getNum()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 101);
        return num;
    }

    static void Main()
    {

        int rn = getNum();
        bool result = false;
        //Console.WriteLine("test");
        int guessCtr = 0;

        while (result != true)
        {   
            Console.Write("Guess a number:");
            int guess = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("guess" + guess);
            //Console.WriteLine("rand num:" + rn);



            if (guess > rn)
            {
                Console.WriteLine("too big");
                result = false;
                guessCtr++;
            }

            else if (guess < rn)
            {
                Console.WriteLine("too small");
                result = false;
                guessCtr++;

            }

            else if (guess == rn)
            {
                Console.WriteLine("correct");
                result = true;
                guessCtr++;

            }

            else
            {
                Console.WriteLine("you wrote an unknown characther please try again");
                result = false;
                guessCtr++;

            }

        }

        Console.WriteLine("You guessed in {0}",guessCtr);

    }
}