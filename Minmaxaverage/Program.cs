using System;

namespace Minmaxaverage
{
  class Program
  {
    static void Main(string[] args)
    {

        //Get valid number of Quizzes from user
        Console.WriteLine("How many quizzes do need to enter?");
        int numberQuiz = Convert.ToInt32(Console.ReadLine());
        while (numberQuiz<1)
        {   //Error prompt if user enters anything less than 1
            Console.WriteLine("You must enter a number greater than or equal to 1.");
            numberQuiz = Convert.ToInt32(Console.ReadLine());
        }
        //Initialize Minimum/Maximum quiz
        int minQuiz = 101;
        int maxQuiz = -1;
        //Creating sum value for average
        double sum = 0;

        //For each Quiz
        for (int newQuiz = 0; newQuiz < numberQuiz; newQuiz++) 
        {
            //Get a valid quiz score
            Console.WriteLine("Please enter quiz score " + (newQuiz+1));
            int quizScore = Convert.ToInt32(Console.ReadLine());
                {
                while (quizScore>100)
                {
                    Console.WriteLine("You must enter a value between 0 and 100.");
                    quizScore = Convert.ToInt32(Console.ReadLine());
                }
                while (quizScore<0)
                {
                    Console.WriteLine("You must enter a value between 0 and 100.");
                    quizScore = Convert.ToInt32(Console.ReadLine());
                }   //Sum starts at 0 and adds per quiz score. This is for the average.
                    sum = sum + quizScore;
                    if (quizScore < minQuiz)
                {   //Calculating minimum of running total
                    minQuiz = quizScore;
                }   
                    if (quizScore > maxQuiz)
                {   //Calculating maximum of running total  
                    maxQuiz = quizScore;
                }
                }
            //Check to see if score is minimum
            Console.WriteLine("The minimum score is: " + (minQuiz));
            //Check to see if score is maximum
            Console.WriteLine("The maximum score is: " + (maxQuiz));
            //Find the average of quiz scores (+1 because we can't start at quiz 0)
            Console.WriteLine("The average test score is: " + ((sum)/(newQuiz+1)));
            {
                
            }

            
        }   
    }
  }
}



