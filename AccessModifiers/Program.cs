using AccessModifiers;
using System;
using System.Windows;
using Tutorial;

public class Program:LearningAccessModifiers
{

    static void Main(string[] args)
    {
        //Ref Parameter Check
        string refValue="No Value";
        int outValue=5;
        string inValue = "InValue";
        RefOutInParm objParmClass=new RefOutInParm();
        objParmClass.ReturnofRefParameter(ref refValue);
        objParmClass.ReturnofOutParameter(out inValue);
        objParmClass.InParameterCheck(inValue);
        //int k = 0;
        ref int k = ref objParmClass.refReturncheck();
        Console.WriteLine("Ref Return Method");
        Console.WriteLine(k);
        k = 100;
        objParmClass.checkrefretunvalue();
        objParmClass.ParamCheck("a", "b", "c");
        objParmClass.ParamCheck(new string[] { "1","2","3"});
        objParmClass.ParamCheck();
        
        Console.WriteLine(refValue);
        Console.WriteLine(outValue);
        Console.WriteLine(inValue);





        //DerivedClassLearning dcl=new DerivedClassLearning();
        //dcl.k = 20;
        //dcl.CheckParentClassvalues();
        //DerivedClassLearning.teststatic = 60;
        //dcl.CheckParentClassvalues();

        //DerivedClassLearning dcl1 = new DerivedClassLearning();        
        //dcl1.CheckParentClassvalues();

        Console.ReadLine();
    }
    // See https://aka.ms/new-console-template for more information
    //Console.WriteLine("Hello, World!");
    

    static void CheckModifiers()
    {
        DerivedClassLearning DCLM = new DerivedClassLearning();
        //learnAM.PublicMehod = 1;
        //learnAM.ProtectedInternalMethod = 2;

        DCLM.CheckParentClassvalues();

        Console.WriteLine("Hello, World Subash!");

        Console.ReadLine();
    }
}