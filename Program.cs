using demo_oob_3.binding;
using demo_oob_3.polymorphism_overriding;
using System;
class prog
{
    #region overloading
    public static int sum(int i, int j)
    {
        int sum = i + j;
        return sum;
    }
    public static int sum(int i, int j, int y)
    {
        int sum = i + j + y;
        return sum;
    }
    public static double sum(double i, double j)
    {
        double sum = i + j;
        return sum;
    }


    static void Main(string[] args, typeA typeA)
    {

        //#region overloadin
        //Console.WriteLine( $" {sum(1, 9)} ");
        //Console.WriteLine($" {sum(1, 9 ,6 )} ");
        //Console.WriteLine($" {sum(1.5, 9.5)} ");
        //#endregion

//        #region overriding 
//        typeA tayepA = new typeA(1);
//        typeA.A = 5;
//        typeA.myfun1();
//        typeA.myfun2();
//        Console.WriteLine("--------------------------");
//        type_b typeb = new type_b(1, 2);
//        typeb.A = 5;
//        typeb.B = 5;
//        typeb.myfun1();
//        typeb.myfun2();
//        #endregion
//        typeA refBase= new type_b(1, 2);
//        refBase.A = 5;
//        refBase.A = 10;
//        refBase.myfun1() ;
//      refBase.myfun2() ;
//#endregion
//----------------------------------------------------------------
fulltimeemployee fulltimeemployee = new fulltimeemployee();
        parttimeemployee parttimeemployee = new parttimeemployee();
        parttimeemployee.Age = 15;
        parttimeemployee.Name = "maged";
        parttimeemployee.hoursrate = 2.5m;
    }
}