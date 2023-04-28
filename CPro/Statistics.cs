using CPro_1.Interface;

namespace CPro_1
{
    public class Statistics : IPlace, IDistance
    {
        private double pathLenght = default;
        private string interestingPlaces = "no";

       Random rndTime = new Random();

        public void FinalDistance(double speed)
        {
            pathLenght = speed * rndTime.Next(1, 24);
            Console.WriteLine("Transport traveled distance {0} km", pathLenght);
        }

        public void InterestingPlaces()
        {
            Console.WriteLine("Interesting places {0}", interestingPlaces);
        }
    }
}
