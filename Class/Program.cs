using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[6];
            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[2] = 100;


            //Array.Resize(ref numbers, 20);
            //numbers[10] = 66;


            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] nums = { 1, 2, 5, 6, 7, 55, 25 };
            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] arr =  {
            //        {1, 2 },
            //        {3, 4 },
            //        {5, 6 }
            //};
            //Console.WriteLine(arr.Rank);

            //string name1 = "Orxan";
            //string surname1 = "Akberov";
            //int age1 = 26;

            //string name2 = "Emil";
            //string surname2 = "Abdullayev";
            //int age2 = 20;

            //string name3 = "Fidan";
            //string surname3 = "Merdanli";
            //int age3 = 17;

            ////Console.WriteLine(name1 + " " + surname1);

            //var obj1 = new
            //{
            //    name = "Orxan",
            //    surname = "Akberov",
            //    age = 26
            //};

            //var obj2 = new
            //{
            //    name = "Emil",
            //    surname = "Abdullayev",
            //    age = 20
            //};

            ////Console.WriteLine(obj2.name + " " + obj2.surname + " " + obj2.age);
            //Console.WriteLine($"{obj2.name} {obj2.surname} Age: {obj2.age}");

            Student st1 = new Student(77);
            st1.name = "Orxan";
            st1.surname = "Akberov";
            st1.age = 26;

            //Student st2 = new Student();
            //st2.name = "Emil";
            //st2.surname = "Abdullayev";
            //st2.age = 20;

            //Console.WriteLine(st1.name);
            //Console.WriteLine(st1.FullName());
            //Console.WriteLine(st1.FullData());

            //Student st3 = new Student
            //{
            //    name = "Cavid",
            //    surname = "Bashirov",
            //    age = 28
            //};
       
        }

        
    }


    class Student
    {

        public Student()
        {
            Console.WriteLine("empty");
        }

        public Student(int age, string addresss):this()
        {
            address = addresss;
            Console.WriteLine("age:" + age);
        }

        public Student(string stuName)
        {
            Console.WriteLine("name" + stuName);
        }


        public string name;
        public string surname;
        public int age;
        public string address;

        public Student(string StudentName, int StudentAge)
        {
            name = StudentName;
            age = StudentAge;
            Console.WriteLine(name + " " + age);
        }








        //public Student()
        //{
        //    Console.WriteLine("constructor");
        //}

        public string FullName()
        {
            return name + " " + surname;
        }

        public string FullData()
        {
            return name + " " + surname + " " + age + " " + adress;
        }

    }

    

}

