using System;

namespace Competencycheck

{
  class Program
  {    static int GetValidInt(int low, int high)
    {
        //Console.WriteLine("Enter an integer between " + low + " and " + high + ".");
        int val = Convert.ToInt32(Console.ReadLine());
    
        while(val < low || val > high)
        {
            Console.WriteLine("The value entered must be between " + low + " and " + high +".");
            val = Convert.ToInt32(Console.ReadLine());
        }
    return val;
    }//end method GetValidInt
    static void Main(string[] args)
    {
    //Get Valid Number of Students
    Console.WriteLine("How many students do you need to enter grades for?");
    int numberOfStudents = GetValidInt (1,1000);

    double sum;
    double sumQ = 0;
    double sumH = 0;
    double sumE = 0;

        for (int newStudent = 0; newStudent < numberOfStudents; newStudent++)
            {
            Console.WriteLine("Please enter student name: ");
            string studentName = (Console.ReadLine());  
            sum = 0;

            for (int newHomework = 0; newHomework < 5; newHomework++) 
                {
                //Get valid homework scores
                Console.WriteLine("Please enter homework " + (newHomework+1) + " score.");
                int homeworkScore = GetValidInt(0,100);
                sumH = sumH + homeworkScore;
                //end for loop gathering homework scores
                }
            for (int newQuiz = 0; newQuiz < 3; newQuiz++) 
                {
                //Get valid quiz scores
                Console.WriteLine("Please enter quiz " + (newQuiz+1) + " score.");
                int quizScore = GetValidInt(0,100);
                sumQ = sumQ + quizScore;
                //end for loop gathering qiuz scores
                }        
            for (int newExam = 0; newExam < 2; newExam++) 
                {
                //Get valid exam scores
                Console.WriteLine("Please enter exam " + (newExam+1) + " score.");
                int examScore = GetValidInt(0,100);
                sumE = sumE + examScore;
                }//end for loop gathering exam scores
            
            double grade = ((sumE+sumH+sumQ)/10);
            Console.WriteLine(grade);
            string finalGrade= " ";
            if (grade < 60)
            {
            finalGrade = "F";  
            }
            if (grade >= 60 & grade < 70)
            {
            finalGrade = "D"; 
            }
            if (grade >= 70 & grade < 80)
            {
            finalGrade = "C";     
            }
            if (grade >= 80 & grade < 90)
            {
            finalGrade = "B"; 
            }
            if (grade > 90)
            {
            finalGrade = "A";     
            }
            
            Console.WriteLine("The grade for " + (studentName) + " is: " + finalGrade);
            }//End student loop

        }//end main
    }//end static  
}//end program