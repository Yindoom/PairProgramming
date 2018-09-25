namespace PairProgramming
{
    public class Cost : ICost
    {
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            double cost = 0;
            if (kilometer < 100)
            {
                cost = 3.20 * kilometer;
            }
            else if (kilometer >= 100 && kilometer < 500)
            {
                if (noOfPassengers < 12)
                {
                    cost = 2.75 * kilometer;
                }
                else if (noOfPassengers >= 12)
                {
                    cost = 3.00 * kilometer;
                }
            }
            else if (kilometer >= 500)
            {
                cost = 2.25 * kilometer;
            }

            cost = cost + 130;
            return cost;
        }
    }
}