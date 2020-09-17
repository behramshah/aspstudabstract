using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Student_Aspirant_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            SDatabase stbase = new SDatabase();
            AsDatabase astbase = new AsDatabase();

            string choice; link1:

            Console.WriteLine("For new student type - 1");
            Console.WriteLine("For new aspirant- 2 ");
            Console.WriteLine("For information about Students-3");
            Console.WriteLine("For information about Aspirants-4");
            Console.WriteLine("For compare Students-5");
            Console.WriteLine("For compare Aspirants-6");
            Console.WriteLine("Type -end- to exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudent(); goto link1;
                    break;
                case "2":
                    CreateAspirant(); goto link1;
                    break;
                case "3":
                    CreateStudent(); goto link1;
                    break;
                case "4":
                    CreateAspirant(); goto link1;
                    break;
                case "5":
                    CreateStudent(); goto link1;
                    break;
                case "6":
                    CreateAspirant(); goto link1;
                    break;

                case "end":

                    break;
                default:
                    Console.WriteLine("Choose from menu"); goto link1;
                    break;
            }


            Console.ReadKey();

                       
       

            static string CreateStudent()
            {
                String surname = null;
                int yearofstudy = 0;
                int number = 0;
                SDatabase stbase = new SDatabase();
                int n = 0;//counter student
                string choice = "1";
                while (choice == "1")
                {

                    Console.WriteLine("type surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("type study year");
                    yearofstudy = Convert.ToInt32(Console.ReadLine());
                    if (yearofstudy > 4) { Console.WriteLine("Study year for bachelors cant be more than 4"); yearofstudy = 4;}
                    Console.WriteLine("type student number");
                    number = Convert.ToInt32(Console.ReadLine());
                    stbase[n] = new StudentPerson(surname, yearofstudy, number);
                    n = n + 1;
                    Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Students information -3 \t For Aspirant information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit");
                    choice = Console.ReadLine();

                }
                while (choice == "3")
                {
                    Console.WriteLine("Enter index");
                    int m = Convert.ToInt32(Console.ReadLine());
                    stbase[m].Display();
                    Console.WriteLine("Object to string = "+stbase[m].ToString());
                    Console.WriteLine("Gethashcode = "+stbase[m].GetHashCode());
                    Console.WriteLine("GetType = "+stbase[m].GetType());
                    Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                while (choice == "5")
                {
                    int a; int b; bool result;
                    Console.WriteLine("Type the 1st student index");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type the 2nd student index");
                    b = Convert.ToInt32(Console.ReadLine());
                    bool studentequal = stbase[a].Equals(stbase[b]);
                    Console.WriteLine("Onject equal"+studentequal);
                    Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                return choice;


            }
             static string CreateAspirant()
            {
                String surname = null;
                int year = 0;
                int number = 0;
                String thesis = null;
                AsDatabase astbase = new AsDatabase();
                int n = 0;//counter aspirant
                string choice = "2";
                while (choice == "2")
                {
                    Console.WriteLine("type surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("type study year");
                    year = Convert.ToInt32(Console.ReadLine());
                    if (year>2) { Console.WriteLine("Study year for Aspirants cant be more than 2"); year = 2; }
                    Console.WriteLine("type student number");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("type Thesis theme");
                    thesis = Console.ReadLine();
                    astbase[n] = new AspirantPerson(surname, year, number, thesis);
                    n = n + 1;
                    Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Student information -3 \t For Aspirant information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                while (choice == "4")
                {
                    Console.WriteLine("Enter index");
                    int m = Convert.ToInt32(Console.ReadLine());
                    astbase[m].Display();
                    Console.WriteLine("Object to string "+astbase[m].ToString());
                    Console.WriteLine("Get hash code "+astbase[m].GetHashCode());
                    Console.WriteLine("Gettype "+astbase[m].GetType());
                    Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }
                while (choice == "6")
                {
                    int a; int b; bool result;
                    Console.WriteLine("Type the 1st student index");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Type the 2nd student index");
                    b = Convert.ToInt32(Console.ReadLine());
                    bool asequal = astbase[a].Equals(astbase[b]);
                    Console.WriteLine("object equal"+asequal);
                    Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t For compare Students-5 \t For compare Aspirants-6 \t Type -end- to exit ");
                    choice = Console.ReadLine();
                }

                return choice;
            }
          


        }
    }
    abstract public class Person
    {
        public string surname;
        public int yearofstudy;
        public int studentnumber;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Person(string surname) { Surname = surname; }
        public int YearofStudy
        {
            get { return yearofstudy; }
            set { yearofstudy = value; }
        }
        public int StudentNumber
        {
            get { return studentnumber; }
            set { studentnumber = value; }
        }
        public Person(string surname, int yearstudy, int studentnumber) { Surname = surname; YearofStudy = yearofstudy; StudentNumber = studentnumber; }
        public Person() { }


        abstract public void Display();
    }
    public class StudentPerson : Person
    {
        string surname;
        int yearofstudy;
        int studentnumber;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int YearofStudy
        {
            get { return yearofstudy; }
            set { yearofstudy = value; }
        }
        public int StudentNumber
        {
            get { return studentnumber; }
            set { studentnumber = value; }
        }
        public StudentPerson(string surname, int yearofstudy, int studentnumber) { Surname = surname; YearofStudy = yearofstudy; StudentNumber = studentnumber; }
        public override void Display()
        {
            Console.WriteLine($"Student={Surname} Year={YearofStudy} Number={StudentNumber} ");
        }

    }
    public class AspirantPerson : Person
    {
        string thesis;
        public string Thesis
        {
            get { return thesis; }
            set { thesis = value; }
        }

        public AspirantPerson(string surname, int yearstudy, int studentnumber, string thesis) : base(surname, yearstudy, studentnumber) { Thesis = thesis; }


        public override void Display() { Console.WriteLine($"Student={Surname} Year={YearofStudy} Number={StudentNumber} Works on { Thesis}"); }
    }
    public class SDatabase
    {
        StudentPerson[] data;
        public SDatabase()
        {
            data = new StudentPerson[99];
        }
        public StudentPerson this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }



    }
    public class AsDatabase
    {
        AspirantPerson[] asdata;
        public AsDatabase()
        {
            asdata = new AspirantPerson[99];
        }
        public AspirantPerson this[int index]
        {
            get
            {
                return asdata[index];
            }
            set
            {
                asdata[index] = value;
            }
        }



    }
}