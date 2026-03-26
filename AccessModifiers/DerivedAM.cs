using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial;

namespace AccessModifiers
{
    internal class DerivedAM : LearningAccessModifiers
    {
        public void CheckModifiers()
        {
            //LearningAccessModifiers.
                PublicMethod = 1;
            protectedMethod = 2;
            ProtectedInternalMethod = 3;
            
        }
    }
}
