namespace Introduction_C_Sharp
    {

    class program
    {
        static void Main(string[] args)
        {

            int CurrentRate, PreviousRate, Unit, Rate, Amount;
            char Type;

            Console.Write("Enter CurrentRate: ");
            CurrentRate = int.Parse(Console.ReadLine());

            Console.Write("Enter PreviousRate: ");
            PreviousRate = int.Parse(Console.ReadLine());

            Unit = Math.Abs(CurrentRate - PreviousRate);
            Console.WriteLine("Total Unit Used: "+Unit);

            Console.Write("Enter Connection Type: ");
            Type = Convert.ToChar(Console.Read());

            switch (Type)
            {
                case 'D':
                    Rate = 2;
                    break;
                case 'I':
                    Rate = 6;
                    break;
                case 'C':
                    Rate = 4;
                    break;
                default:
                    Console.WriteLine("Invalid Type");
                    Rate = 0;
                    break;
            }

            Amount = Rate * Unit;
            Console.WriteLine("Amount= "+Amount);








        }
    }
}

