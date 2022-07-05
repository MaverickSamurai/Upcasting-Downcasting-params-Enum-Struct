using System;
using UDPESPractice.Models;

namespace UDPESPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //GetElements(1, 2, 3, 4, 8, 9, 11, 12);
            //int[] arr = { 1, 5, 7, 9 };
            #endregion


            #region Enum
            //CheckRole(0);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);
            //Console.WriteLine(test.Word);

            //string name = null;
            //int? age = null;
            //int? age = 40;
            //int? age1 = null;

            //if (name == null)
            //{
            //    Console.WriteLine("yes");
            //}
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            //var result = age == null ? 55 : 60;

            //var result = age ??  60;
            //var sumeResult = Sum();
            //var result = age ?? sumeResult;
            //Console.WriteLine(result);


            //Test test = null;
            //Console.WriteLine(test.Word.ToString());

            #endregion


            #region Sturct
            //int age = 87;
            //Test test = new Test();
            //test.Num = 55;
            //Console.WriteLine(test.Num);
            //Test1 test = new Test1("Mirsamir");
            //Console.WriteLine(test.Num);

            //Test2 test = new Test2(15);

            #endregion

            #region Downcasting,Unboxing,Explicit
            //int m = 5;
            //byte n =(byte) m;
            //Console.WriteLine(n);

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();


            //Shark shark3 = (Shark)shark2;


            //object[] objects = { 5, 9, "Aleykum", shark3 };

            //foreach (var item in objects)
            //{
            //    Shark shark = item as Shark;

            //    if (shark != null)
            //    {
            //        Console.WriteLine(shark.Weight);
            //    }


            //if (item is Shark t)
            //{
            //    ((Shark)item).Weight = 500;
            //    Console.WriteLine(((Shark)item).Weight);

            //}

            //((Shark)item).Weight = 500;
            //Console.WriteLine(((Shark)item).Weight);
            #endregion
        }





        #region Upcasting,Boxing,Implicit 
        //Eagle eagle1 = new Eagle();

        //Eagle eagle3 = new Eagle();

        //Shark shark1 = new Shark();

        //Animal shark2 = new Shark();

        ////Animal animal = eagle1;


        //Animal eagle2 = eagle1;

        //Animal[] animals = { eagle1, eagle2, eagle3, shark1, shark1 };

        //foreach (var item in animals)
        //{
        //    //item.Eat();
        //    item.Test();
        //}

        //eagle1 = eagle2;




        //eagle1.Eat();

        #endregion



    }

    #region Struct
    //struct Test1
    //{
    //    public int Num { get; set; }


    //    public Test1(string name)
    //    {
    //        Num = 58;
    //        Console.WriteLine(Num);
    //    }
    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 66;
    //    public Test2()
    //    {
    //        Console.WriteLine("Bosh");
    //    }

    //    public Test2(int a)
    //    {
    //        Console.WriteLine("Dolu");
    //    }
    //}
    #endregion

    #region Nullable
    //static int Sum()
    //{
    //    return 1;
    //}
    #endregion


    #region Params
    //public static void GetElements(params int[] nums)
    //{
    //    foreach (var item in nums)
    //    {
    //        Console.WriteLine(item);
    //    }

    //}
    #endregion

    #region Enum
    //static void CheckRole(int roleId)
    //{
    //    switch (roleId)
    //    {
    //        case (int)RoleId.SuperAdmin:
    //            Console.WriteLine("Super Admin");
    //            break;
    //        case (int)RoleId.Admin:
    //            Console.WriteLine("Admin");
    //            break;
    //        case (int)RoleId.Member:
    //            Console.WriteLine("Member");
    //            break;
    //        default:
    //            Console.WriteLine("Not Found role id");
    //            break;
    //    }

    //}
    #endregion


    #region Nullable
    //class Test
    //{
    //    public int Number { get; set; }

    //    public string Word { get; set; }
    //}
    #endregion

    #region Enum



    //public enum RoleId
    //{
    //    SuperAdmin,
    //    Admin,
    //    Member
    //}
    #endregion
} 

