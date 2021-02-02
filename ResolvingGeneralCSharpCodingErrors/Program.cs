using System;


namespace ResolvingGeneralCSharpCodingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            //  References.Greetings();    //1.2 with  using ResolvingGeneralCSharpCodingErrors.MisunderstandingPassbyReference;



            //MyDisposable disposable; //1.3 with    using ResolvingGeneralCSharpCodingErrors.MisunderstandingDisposeAndGarbageCollectorRelation;
            //using (disposable = new MyDisposable())
            //{

            //}
            //disposable.PrintX();



            Console.WriteLine("Hello, World!"); //1.4. Incorrectly Implementing Equals and GetHashCode



            //Product product = new Product();  //1.5. Handling Exceptions Correctly, Improvisation
            //Console.WriteLine("Enter product name:");
            //product.Name = Console.ReadLine();
            //Console.WriteLine("Enter desired price:");
            //product.Price = decimal.Parse(Console.ReadLine());
            //Exceptions.DoShopping(product);


            //while (true)          //1.5 with          using ResolvingGeneralCSharpCodingErrors.HandlingExceptionsCorrectly;
            //{
            //    try
            //    {
            //        Product product = new Product();
            //        Console.WriteLine("Enter product name:");
            //        product.Name = Console.ReadLine();
            //        Console.WriteLine("Enter desired price:");
            //        product.Price = decimal.Parse(Console.ReadLine());
            //        Exceptions.DoShopping(product);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        Console.WriteLine("________________________________________________________________________________________________________________________");
            //        throw;
            //    }

            //}



            //Car toyota = new Toyota(); //1.6 with          using ResolvingGeneralCSharpCodingErrors.MisunderstandingVirtualAndOverride;     
            //toyota.Accelerate();
            //toyota.Run();

            //Car ferrari = new Ferrari();
            //ferrari.Accelerate();

            //ferrari.Run();
            //ferrari.Stop();
            //Ferrari realFerrari = (Ferrari)ferrari;
            //realFerrari.Stop();



            // Warnings.User();       //1.7 with  using ResolvingGeneralCSharpCodingErrors.IgnoringCompilerWarnings;

        }
    }
}
