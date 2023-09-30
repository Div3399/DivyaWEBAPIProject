using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WeltecDemo.MyClass
{
    public class ClassHome
    {

       public decimal Sum (decimal A, decimal B)
        {
            decimal C = 0;
            C = A + B;
            return C;
        }
        public decimal Sub(decimal A, decimal B) 
        {   
            decimal C = 0;
            C = A - B;
            return C;
        
        }
        public decimal Multy(decimal A, decimal B)
        {
            decimal C = 0;
            C = A * B;
            return C;
        }
    }
}