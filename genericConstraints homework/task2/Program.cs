using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static task2.Program;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IMathOperation<int> intMath = new IntMathOperation();
            Console.WriteLine("Integer Operations:");
            Console.WriteLine($"Addition: {intMath.Add(5, 10)}");
            Console.WriteLine($"Subtraction: {intMath.Subtract(10, 5)}");
            Console.WriteLine($"Multiplication: {intMath.Multiply(5, 10)}");

            IMathOperation<double> doubleMath = new DoubleMathOperation();
            Console.WriteLine("\nDouble Operations:");
            Console.WriteLine($"Addition: {doubleMath.Add(5.5, 10.5)}");
            Console.WriteLine($"Subtraction: {doubleMath.Subtract(10.5, 5.5)}");
            Console.WriteLine($"Multiplication: {doubleMath.Multiply(5.5, 10.5)}");



            //IMathOperation<int> intMath = new IntMathOperation();
            //Console.WriteLine("Int Operations:");
            //Console.WriteLine($"Add: {intMath.Add(5, 3)}"); // 8
            //Console.WriteLine($"Subtract: {intMath.Substract(5, 3)}"); // 2
            //Console.WriteLine($"Multiply: {intMath.Multiply(5, 3)}"); // 15

            //// Example using DoubleMathOperation
            //IMathOperation<double> doubleMath = new DoubleMathOperation();
            //Console.WriteLine("\nDouble Operations:");
            //Console.WriteLine($"Add: {doubleMath.Add(5.5, 3.3)}"); // 8.8
            //Console.WriteLine($"Subtract: {doubleMath.Substract(5.5, 3.3)}"); // 2.2
            //Console.WriteLine($"Multiply: {doubleMath.Multiply(5.5, 3.3)}"); // 18.15
        }








        //IntMathOperation operations = new IntMathOperation();
        //int sum = operations.Add(5, 3); // 8
        //int difference = operations.Subtract(5, 3); // 2

        //Console.WriteLine($"Sum: {sum}"); // Outputs: Sum: 8
        //Console.WriteLine($"Difference: {difference}");





    }




    public interface IMathOperation<T> where T : struct
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
    }

    public class IntMathOperation : IMathOperation<int>
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;
    }

    public class DoubleMathOperation : IMathOperation<double>
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;
    }





    //public interface IMathOperation<T> where T : struct


    //    {

    //        T add(T value);
    //        T Substract(T a, T b);
    //        T Multiply(T a, T b);



    //    }



    //public class IntMathOperation : IMathOperation<int>
    //{

    //    public int Add(int a, int b) { return a + b; }




    //    public int Substract(int a, int b) { return a - b; }


    //    public int Multiply(int a, int b) { return a * b; }

    //    int IMathOperation<int>.add(int value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public class DoubleMathOperation : IMathOperation<double>
    //    {



    //        public double add(double a, double b)
    //        { return a + b; }

    //        public double Substract(double a, double b)
    //        { return a - b; }


    //        public double Multiply(double a, double b)
    //        { return a + b * 2; }

    //        double IMathOperation<double>.add(double value)
    //        {
    //            throw new NotImplementedException();
    //        }








    //exeptionsss






}










//public  interface IMathOperation
//{

//    int Add(int a, int b);
//    int Subtract(int a, int b);




//    void PlusMethod();
//    void MinusMethod();

//    void MultiplicationMethod();


//}




//public class IntMathOperation : IMathOperation
//{



//  public int PlusMethod( int a , int b)

//    {


//        //int number1 = Convert.ToInt16(Console.ReadLine());  


//        //int number2 = Convert.ToInt16(Console.ReadLine());


//        return a + b;   



//    }

//    public int MultiplicationMethod(int a, int b) 

//    { 
//    return (a + b) / 2; 

//    }

//   public int MinusMethod(int a, int b)

//    {

//        return  a- b;

//    }

//    public int Add(int a, int b)
//    {
//        throw new NotImplementedException();
//    }

//    public int Subtract(int a, int b)
//    {
//        throw new NotImplementedException();
//    }

//    public void PlusMethod()
//    {
//        throw new NotImplementedException();
//    }

//    public void MinusMethod()
//    {
//        throw new NotImplementedException();
//    }

//    public void MultiplicationMethod()
//    {
//        throw new NotImplementedException();
//    }
//}


//public class DoubleMathOperation : IMathOperation

//{

//    public void PlusMethod()

//    {


//    }

//    public void MultiplicationMethod()

//    {


//    }

//    public void MinusMethod()

//    {

//    }

//    int IMathOperation.Add(int a, int b)
//    {
//        throw new NotImplementedException();
//    }

//    int IMathOperation.Subtract(int a, int b)
//    {
//        throw new NotImplementedException();
//    }
//}




