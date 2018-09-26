using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_Classes
{
    public class Student
    {
        private string name;
        private string studentNumber;
        private int lastTestScore;
        //make a comment
        public Student(string sName, string sStNum)
        {
            name = sName;
            studentNumber = sStNum;
            takeTest();
        }
        //another comment
        public string getName()
        {
            return name;
        }

        public string getStNum()
        {
            return studentNumber;
        }

        public int getScore()
        {
            return lastTestScore;
        }

        public void takeTest()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            lastTestScore = rand.Next(0, 101);
        }
    }

    public class GADE
    {
        public Student[] students = new Student[5];

        public void printStudents()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(students[i].getName() + " " + students[i].getStNum() + " " + students[i].getScore());
            }
        }

        public void highest()
        {
            Student highest = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if(highest.getScore() < students[i].getScore())
                {
                    highest = students[i];
                }
            }

            Console.WriteLine("The student with the highest mark is " + highest.getName());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GADE GADEPTA = new GADE();
            
            GADEPTA.students[0] = new Student("Carl", "1345345345");
            GADEPTA.students[1] = new Student("Jace", "13453651345");
            GADEPTA.students[2] = new Student("Irton", "13456546545");
            GADEPTA.students[3] = new Student("Mekeal", "13325345");
            GADEPTA.students[4] = new Student("Sibrina", "1466345345");
            GADEPTA.students[5] = new Student("Amorie", "134534687");

            GADEPTA.printStudents();

            Console.ReadLine();
        }
    }
}
