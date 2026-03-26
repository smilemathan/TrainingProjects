namespace Tutorial
{
    public class LearningAccessModifiers
    {
        private static int _privateFiled; // Accessible only within this class
        private static int _publicFiled;
        private static int _protectedFiled;
        private int _internalFiled;
        private int _protectedInternalFiled;
        private int _privateProtectedFiled;
        public const int h = 10;
        public int k;
        public static int teststatic = 40;

        public LearningAccessModifiers()
        {
            //teststatic = 40;
        }



        public void ReadOnlyCHeck()
        {
            //k = 21;
        }
        private static int PrivateMethod
        {
            get { return _privateFiled; }
            set { _privateFiled = value; }
        }

        public static int PublicMethod
        {
            get { return _publicFiled; }
            set { _publicFiled = value; }
        }

        protected static int protectedMethod
        {
            get { return _protectedFiled; }
            set { _protectedFiled = value; }
        }

        internal int InternalMethod
        {
            get { return _internalFiled; }
            set { _internalFiled = value; }
        }

        protected internal int ProtectedInternalMethod
        {
            get { return _protectedInternalFiled; }
            set { _protectedInternalFiled = value; }
        }

        private protected int PrivateProtectedMethod
        {
            get { return _privateProtectedFiled; }
            set { _privateProtectedFiled = value; }
        }

    }
}
