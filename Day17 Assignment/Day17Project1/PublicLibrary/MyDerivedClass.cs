using System;
using System.Collections.Generic;
using PavanLibrary;

namespace PublicLibrary
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: INHERITING BASECLASS IN DERIVEDCLASS
    /// </summary>
    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 10;
          //  b = 15; Private Class cannot be accessed//
            c = 20;
           // d = 25;  internal class can't get access//
            e = 30;  
        }
    }
    public class MyDerivedOtherClass
    {   
        public void MyDerivedOtherClassMethod()
        {
            MyBaseClass bc = new MyBaseClass();
            bc.a = 10;
            //  bc.b = 15; Private class can't get access
            //   bc.c = 20; Protected class can't get access
            //  bc.d = 25; internal class can't get access
            //  bc.e = 30; Protected internal class can't get access
        }
    }
}
