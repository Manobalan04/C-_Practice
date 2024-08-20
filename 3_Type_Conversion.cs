namespace Introduction_C_Sharp
    {

    class program
    {
        static void Main(string[] args)
        {
            //float to int
            float a = 23.56f;
            int b = (int)a;
            Console.WriteLine("Float To Int :"+b);

            //Int to long
            int c = 3;
            long d = c;
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);

            //int to string
            int e = 2;
            String f =e.ToString();
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            //float to string
            float g = 4.34f;
            String h = g.ToString();
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            //Boolean to string
            bool i = true;
            String j = i.ToString();
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            

        }
    }
}

