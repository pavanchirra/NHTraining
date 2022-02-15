using System;
using System.Collections.Generic;


namespace PavanLibrary
{
    /// <summary>
    /// DONE.BY: PAVAN
    /// PURPOSE: CREATING BASECLASS AND DERIVED CLASS
    /// </summary>
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
       protected internal int e;

        public void MyBaseClassMethod()
        {
            a = 10;
            b = 15;
            c = 20;
            d = 25;
            e = 30;
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 10;
           // b = 15;   In this case Private class cannot be accessed//
            c = 20;
            d = 25;
            e = 30;    
        }
    }
    public class MyOtherClass
    { 
        public void MyOtherClassMethod()
        {
            MyBaseClass bc = new MyBaseClass();
            bc.a = 10;
          //  bc.b = 15;    Private Class is not accessed
          //  bc.c = 20;    Protected Class is not accessed
            bc.d = 25;
            bc.e = 30;    
        }
    }
}
