using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FutaStudent futaStudent1 = new FutaStudent();
            futaStudent1.Name = "Osagie";
            futaStudent1.RegNum = 000;
            futaStudent1.CGPA = 4;
            FutaStudent.addToStudentList(futaStudent1);
            FutaStudent futaStudent2 = new FutaStudent();
            futaStudent2.Name = "Oladapo";
            futaStudent2.RegNum = 001;
            futaStudent2.CGPA = 7;
            FutaStudent.addToStudentList(futaStudent2);
            Console.WriteLine(FutaStudent.linearSearcherByRegNo(001));
            Console.WriteLine(FutaStudent.BinarySearchOnSortedStudents(001));
            Console.WriteLine(FutaStudent.FutaStudentList);




        }
    }
    class FutaStudent
    {
        public FutaStudent()
        {


        }
        
        public static void addToStudentList(FutaStudent futaStudent)
        {
            if (FutaStudentList == null)
            {
                FutaStudentList = new List<FutaStudent>();
                FutaStudentList.Add(futaStudent);
            }
            else
            {
                FutaStudentList.Add(futaStudent);
            }
        }
        public int RegNum { get; set; }
        public string Name { get; set; }
        public int CGPA { get; set; }
        public static List<FutaStudent> FutaStudentList { get; set; }

        public static string linearSearcherByRegNo(int regNo)
        {

            int n = FutaStudentList.Count;
            for (int i = 0; i < n; i++)
            {
                if (FutaStudentList[i].RegNum == regNo)
                {
                    return FutaStudentList[i].Name;
                }
               
            }

            return "Doneee";
        }
        public static string BinarySearchOnSortedStudents(int regNo)
        {
            int min = 0;
            int max = FutaStudentList.Count - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (regNo== FutaStudentList[mid].RegNum)
                {
                    return FutaStudentList[mid].Name;
                }
                else if (regNo < FutaStudentList[mid].RegNum)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return "Not Found";
        }

    }
    //public static List<FutaStudent> BubbleSortStudentAccordingToRegNo()
    //{
    //    return;
    //}

    




}

    

