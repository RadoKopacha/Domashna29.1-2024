using System.Collections;

namespace Dnevnik
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            ArrayList list = new ArrayList();
            Console.Write("Enter how many students: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                list.Add(name);
                Console.Write("Enter age:  ");
                int age = int.Parse(Console.ReadLine());
                list.Add(age);
                Console.Write("Enter grades: ");
                double grade = double.Parse(Console.ReadLine());
                list.Add(grade);
            }

            Console.Write("Do you want to remove a student: Y or N: ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'Y')
            {
                Remove(list);
            }
            Console.Write("Do you want to add a student: Y or N: ");
            answer = char.Parse(Console.ReadLine());
            if (answer == 'Y')
            {
                Addstudent(list);
            }
            Youngest(list);
        }


        static void Addstudent(ArrayList list)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            list.Add(name);
            Console.Write("Enter age:  ");
            int age = int.Parse(Console.ReadLine());
            list.Add(age);
            Console.Write("Enter grades: ");
            double grade = double.Parse(Console.ReadLine());
            list.Add(grade);
        }
        static void Remove(ArrayList list)
        {
            Console.Write("Enter name of the student: ");
            string studentname = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is string)
                {
                    if (list[i] == studentname)
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i + 2);
                    }
                }
            }
        }
        static void Youngest(ArrayList list)
        {
            int minage = 99999;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is int)
                {
                    if (minage > (int)list[i])
                    {
                        minage = (int)list[i];
                        index = i;
                    }
                }
            }

            Console.WriteLine($"The youngest person is {list[index - 1]} with age of {minage} years and grade: {list[index + 1]}.");


    }   }
}
