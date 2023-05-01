using CPro_1.Helper;
using System.Linq;

namespace CPro_1.Taska1_4
{
    public class Tasks1_4
    {   
        private int[] massNumber;
        public int[] MassNumber { get; set; }

        private void ShowData(IEnumerable<int> numbers)
        {
            Helppppppp.Delimetr();

            foreach (int number in numbers)
            {
                Console.WriteLine("Result: {0}", number);
            }

        }
        public void NonPartValue()
        {
            massNumber = MassNumber;
            var resultMassNumber = massNumber.Where(number => number % 2 != 0);
            ShowData(resultMassNumber);
        }

        public void SqareNonPartValue()
        {
            massNumber = MassNumber;
            var resultMassNumber = massNumber.Where(number => number % 2 != 0)
                .Select(number => number*number);
            ShowData(resultMassNumber);
        }

        public void SumNumbers()
        {
            massNumber = MassNumber;
            var resultMassNumber = massNumber.Sum();
            Helppppppp.Delimetr();
            Console.WriteLine("Total sum is: {0}", resultMassNumber);

        }
    }
}
