using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class DerivedClassLearning : LearningAccessModifiers
    {
        
        public void CheckParentClassvalues()
        {
            LearningAccessModifiers LAM=new LearningAccessModifiers();
            Console.WriteLine("Public readonly value: " + LAM.k);
            Console.WriteLine(this.k.ToString());
            Console.WriteLine(LearningAccessModifiers.teststatic.ToString());
            LearningAccessModifiers.PublicMethod = 20;
            //LearningAccessModifiers.
            //PublicMethod = 10;
            //protectedMethod = 20;
            //ProtectedInternalMethod = 30;
            //InternalMethod = 32;
            //PrivateProtectedMethod = 31;
            //h = 20;
            //LearningAccessModifiers.h = 80;
            int j = LearningAccessModifiers.h;
        }
      
        
    }
}
