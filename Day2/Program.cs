namespace Day2
{
    class Program
    {
        static void Main()
        {
            //if you want to write text in one line 
            Console.WriteLine("Hello ");

            //value Datatype
            string FirstName = "Khaloud", LastName = "Hamed" , job="Student in Code Academy";
            Console.WriteLine(FirstName +" "+ LastName +"\nMy jobe is "+ job);


            int age; //Variale Decleration
            age = 26;
            Console.WriteLine("My age is = "+age);

            //Renge Exmple:
            #region longeEx
            long ssn = 2635455543224;
            Console.WriteLine("My long num is = " + ssn);

            //Decimal
            double payment = 3.45;
            float money = 2.45f; 
            decimal salary= 2.45m;

            Console.WriteLine("The double is = " + payment + " ,The float is = " + money + " ,The decimal is = " + salary);

            #endregion


            Console.WriteLine("----------------Refrence Old------------");
            Object obj1 = new Object();
            Object obj2 = new Object();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("----------------Refrence new------------");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
        //one line comment

        /*multie line comment*/

        /* ctrl + k +c ==> this will comment (k ==> make  ::: c ==> comment)
         * ctrl + u +c ==> this will comment (k ==> make  ::: u ==> Uncomment)
         */
    }
}