namespace Introduction_C_Sharp
    {

    class program
    {
        static void Main(string[] args)
        {
            int p, n, r, si;
            Console.Write("Enter Value for P:");
            p=int.Parse(Console.ReadLine());

            Console.Write("Enter Value for N:");
            n=int.Parse(Console.ReadLine());

            Console.Write("Enter Value for R:");
            r=int.Parse(Console.ReadLine());

            si = (p * n * r) / 100;
            Console.WriteLine("Simple Interest:"+si);


            // another method
            Console.Write("Enter value a :");
            String m=Console.ReadLine();
            Console.Write("Enter value a :");
            String s=Console.ReadLine();
 
            int j = int.Parse(m);
            int k = int.Parse(s);
            int l = j + k;
            Console.WriteLine("Total :"+l);


        }
    }
}

