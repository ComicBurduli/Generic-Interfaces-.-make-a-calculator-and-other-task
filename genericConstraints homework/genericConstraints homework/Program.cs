using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericConstraints_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var example = new MyGenericClass<int, string>(15, "hello World!");


                example.Print();


            example.UTupdateMethod(16, "Are you sure you want to change your name ?");


                example.Print();



        }
    }

    public class MyGenericClass<T, U>  where T : struct
                                       where U : class
    {


        
        /// field and property 
        
        public  T  _Ttype;
        private int v1;
        private string v2;

        public MyGenericClass(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public U Utype { get; set; }

        /// field and property (end)

        public void addValuesTopropandfield(T Tvalue , U Uvalue)
        {
            _Ttype = Tvalue;
            Utype = Uvalue; 

        }



        public T getTvalue()
        {
            return _Ttype;
        }


        public U getUvalue()
        {
            return Utype;
        }

        ///update method
        public void UTupdateMethod(T Tupdatedvalue , U Uupdatedvalue) 
        {
            _Ttype = Tupdatedvalue;
            Utype = Uupdatedvalue;
        }




        //public void getvalues(T Tupdatedvalue , U Uupdatedvalue)
        //{
        //     var example = new MyGenericClass<int, string>(15, "saba burduli") { }  ;
        //    Console.WriteLine($"student Name : {Uupdatedvalue} and age ; {Tupdatedvalue} ");
        //}




        ///Print method
        public void Print(T Tupdatedvalue, U Uupdatedvalue)
        {
            Console.WriteLine($"Print class members : 1. {Tupdatedvalue} 2. {Uupdatedvalue} ");
        }



    };
    
    
    
    };




