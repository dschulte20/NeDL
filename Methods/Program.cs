using System;

namespace Methods

{
  class Program
  {
    static int MyMin(int x, int y)
    {
            if (x < y)
        {
            return x;
        }
            else return y;
    }  
    static int MyMax(int x, int y)
    {
            if (x > y)
        {
            return x;
        }
            else return y;
    }
    static int GetValidInt(int low, int high)
    {
        Console.WriteLine("Enter an integer between " + low + " and " + high + ".");
        int val = Convert.ToInt32(Console.ReadLine());
    
        while(val < low || val > high)
        {
            Console.WriteLine("The value entered must be between " + low + " and " + high +".");
            val = Convert.ToInt32(Console.ReadLine());
        }
    return val;
    }
    static void Main(string[] args)
    {
        //Get valid number of Quizzes from user
        Console.WriteLine("How many quizzes do you need to enter?");
        int numberQuiz = GetValidInt(1,1000);

        //Initialize Minimum/Maximum quiz
        int minQuiz = 101;
        int maxQuiz = -1;
        //Creating sum value for average
        double sum = 0;

        //For each Quiz
        for (int newQuiz = 0; newQuiz < numberQuiz; newQuiz++) 
            {
            //Get a valid quiz score
            Console.WriteLine("Please enter quiz score: " + (newQuiz+1));
            int quizScore = GetValidInt(0,100);
                
            sum = sum + quizScore;
                    
            minQuiz = MyMin(quizScore,minQuiz);
            //Calculating minimum of running total
                   
             maxQuiz = MyMax(quizScore,maxQuiz);
            //Calculating maximum of running total  
            }//End for each quiz

            //Check to see if score is minimum
            Console.WriteLine("The minimum score is: " + (minQuiz));
            //Check to see if score is maximum
            Console.WriteLine("The maximum score is: " + (maxQuiz));
            //Find the average of quiz scores (+1 because we can't start at quiz 0)
            Console.WriteLine("The average test score is: " + ((sum)/(numberQuiz)));
    }//end main
    }//end program
  }//namespace




