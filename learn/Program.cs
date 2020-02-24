using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Your name:{0} \nYour age:{1}",name,age);

            Console.ReadKey();
            // Попробуем создать массивы и поработать с ними
            Console.Clear();
            int [] marks = new int[] {1,2,3,4,5};
            Console.Write("In school u can get marks: ");
            foreach(int i in marks)
                Console.Write($"{i}"+" ");

            Console.ReadKey();
            // А сейчас попробуем написать соритровку пузырьком для введенного с клавиатуры массива
            Console.Clear();
            int [] mas = new int[5];
            Console.WriteLine("Enter 5 values in array: ");
            for(int i = 0; i < mas.Length; i++){
                Console.Write("{0}'s value: ", i+1);
                mas[i] = Int32.Parse(Console.ReadLine());
            }
            //Console.ReadKey();
            Console.WriteLine("Entered array: ");
            for(int i = 0;i < mas.Length; i++)
                Console.Write(mas[i]+ " ");
            Console.ReadKey();
            
            BubbleSort(mas);
            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            for(int i = 0;i < mas.Length; i++)
                Console.Write(mas[i]+ " ");


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("C# have a data type enum");
            Console.WriteLine("Let's try to work with enum");
            Console.WriteLine("Best example, when I can find it's example with math operation");
            Console.WriteLine("Check this in code :)");
            MathOp(2.0,13.0, Operation.Subtract);
            
            Console.WriteLine("Кортеж - one more data type in C#");
            (int, int) a = (2,4);
            Console.WriteLine("Result is: {0}", Pow(a));
        }

        static int Pow((int number, int count) a){
            int n = a.number;
            for(int i = 0; i<a.count-1; i++)
                a.number *= n;
            return a.number;
        }


        enum Operation
        {
        Add = 1,
        Subtract,
        Multiply,
        Divide
        }
 
        static void MathOp(double x, double y, Operation op)
        {
        double result = 0.0;
 
        switch (op)
        {
            case Operation.Add:
                result = x + y;
                break;
            case Operation.Subtract:
                result = x - y;
                break;
            case Operation.Multiply:
                result = x * y;
                break;
            case Operation.Divide:
                result = x / y;
                break;
        }
 
        Console.WriteLine("Result is {0}", result);
        }

        static void BubbleSort(int[] array){
            int temp;
            for(int i=0; i < array.Length-1; i++)
                for(int j=0; j < array.Length-1;j++)
                    if(array[j]>array[j+1]){
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
        }
    }
}
