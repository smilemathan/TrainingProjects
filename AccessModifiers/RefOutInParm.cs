using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class RefOutInParm
    {
        // Ref Parameter should be intiaized before it pass to the method
        //Out paramter should be intialized with in the method/function
        //In paramter we can not change the value inside the Method/function
        public void ReturnofRefParameter(ref string refValue)
        {
            refValue = "70";
        }

        public void ReturnofOutParameter(out string outVal)
        {
            outVal = "50";
        }

        public void InParameterCheck(in string inValue)
        {
            //inValue = 60;
        }

        public void ParamCheck(params string[] paramsCheck)
        {
            if (paramsCheck.Count() == 0)
            {
                Console.WriteLine("there is no params");
            }
            foreach (string param in paramsCheck)
            {
                Console.WriteLine(param);
            }
        }
        int i = 10;
        public ref int refReturncheck()
        {
            i = 99;
            return ref i;
        }

        public void checkrefretunvalue()
        {
            Console.WriteLine("Ref REturn Value is : " + i.ToString());
        }



    }
}
