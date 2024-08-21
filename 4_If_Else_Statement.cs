namespace Introduction_C_Sharp
    {

    class program
    {
        static void Main(string[] args)
        {

            int JuneSales, JulySales, AugustSales, Total, Average, Incentive ;

            Console.Write("Enter June Month Sales: ");
            JuneSales= int.Parse(Console.ReadLine());

            Console.Write("Enter July Month Sales: ");
            JulySales= int.Parse(Console.ReadLine());

            Console.Write("Enter August Month Sales: ");
            AugustSales= int.Parse(Console.ReadLine());

            Total= JuneSales + JulySales + AugustSales;
            Average = Total / 3;

            if (JuneSales >= 25 && JulySales >= 25 && AugustSales >= 25)
            {
                if (Total >= 150)
                {
                    Incentive = Total * 20 / 100;
                }
                else if (Total > 100)
                {
                    Incentive = Total * 15 / 100;
                }
                else if (Total >= 75)
                {
                    Incentive = Total * 10 / 100;
                }
                else
                {
                    Incentive = 0;
                }
            }
            else
            {
                Incentive= 0;
            }
            Console.WriteLine("Incentive Earned= " +Incentive);
            



            

        }
    }
}

