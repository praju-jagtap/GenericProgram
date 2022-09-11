namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Print Array\n2.Using Generic Print Array\n");
                Console.WriteLine("Please Enter Your Choice : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------\n");
                switch (option)
                {
                    case 1:
                        PrintArray printArray = new PrintArray();
                        printArray.createArray();
                        break;
                    case 2:
                        UsingGenericArray usingGenericArray = new UsingGenericArray();
                        usingGenericArray.usingGeneric();
                        break;

                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }
            }
        }
    }
}
