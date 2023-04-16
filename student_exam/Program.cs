﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("СПИСОК ОЦЕНОК СТУДЕНТОВ ПО ПЯТИ ЭКЗАМЕНАМ\n");
            int[,] marks = new int[25, 5];
            int rows = 25;
            int columns = 5;
            double average_student = 0;
            double average_subject1 = 0;
            double average_subject2 = 0;
            double average_subject3 = 0;
            double average_subject4 = 0;
            double average_subject5 = 0;
            int max_subject = 0;
            int min_subject = 0;
            double max_average_student = 0;
            double min_average_student = 10000;
            int max_student = 0;
            int min_student = 0;
            double max_average_subject = 0;
            double min_average_subject = 10000;
            double[] subject_averages = new double[5];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    marks[i, j] = rand.Next(2, 6);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (i+1 < 10)
                    Console.Write($"Студент {i + 1}        ");
                else
                    Console.Write($"Студент {i + 1}       ");
                for (int j = 0; j < columns; j++)
                {
                    switch (j)
                    {
                        case 0:
                            average_subject1 = average_subject1 + marks[i, j];
                            break;
                        case 1:
                            average_subject2 = average_subject1 + marks[i, j];
                            break;
                        case 2:
                            average_subject3 = average_subject1 + marks[i, j];
                            break;
                        case 3:
                            average_subject4 = average_subject1 + marks[i, j];
                            break;
                        case 4:
                            average_subject5 = average_subject1 + marks[i, j];
                            break;
                    }
                    average_student = average_student + marks[i, j];
                    Console.Write($"{marks[i, j]}  ");
                }
                average_student = Math.Round(average_student / 5, 2);
                if (max_average_student < average_student)
                {
                    max_average_student = average_student;
                    max_student = i + 1;
                }
                if (min_average_student > average_student)
                {
                    min_average_student = average_student;
                    min_student = i + 1;
                }
                Console.WriteLine($"    {average_student}\n");
                average_student = 0;
            }
            average_subject1 = Math.Round(average_subject1 / 25, 2);
            average_subject2 = Math.Round(average_subject2 / 25, 2);
            average_subject3 = Math.Round(average_subject3 / 25, 2);
            average_subject4 = Math.Round(average_subject4 / 25, 2);
            average_subject5 = Math.Round(average_subject5 / 25, 2);
            Console.WriteLine($"            {average_subject1}  {average_subject2}  {average_subject3}  {average_subject4}  {average_subject5}");
            Console.WriteLine($"\nУ студента {max_student} макс. ср. балл ({max_average_student})");
            Console.WriteLine($"У студента {min_student} мин. ср. балл ({min_average_student})");
            subject_averages[0] = average_subject1;
            subject_averages[1] = average_subject2;
            subject_averages[2] = average_subject3;
            subject_averages[3] = average_subject4;
            subject_averages[4] = average_subject5;
            for (int i = 0; i < subject_averages.Length; i++)
            {
                if (max_average_subject < subject_averages[i])
                {
                    max_average_subject = subject_averages[i];
                    max_subject = i + 1;
                }
                if (min_average_subject > subject_averages[i])
                {
                    min_average_subject = subject_averages[i];
                    min_subject = i + 1;
                }
            }
            Console.WriteLine($"\nМакс. ср. балл ({max_average_subject}) набран по предмету {max_subject}");
            Console.WriteLine($"Мин. ср. балл ({min_average_subject}) набран по предмету {min_subject}");
        }
    }
}
