class Program
{
    
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        
        Console.WriteLine("Wprowadź a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź b: ");
        b = int.Parse(Console.ReadLine());
           
        
    }
   /* public static int NWD(int a, int b)
    {
        do
        {
            if (a == b)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
        }while(a!=b);
    }*/
}

