using System;

//I have resigned myself to doing it the Ariel way because I couldn't get my way (below) to work

namespace TowersOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Towers of Hanoi! Enter the number of disks you'd like to use:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Minimum number of moves\nUsing Recursion (Hanoi(n)): " + Hanoi(n));
            Console.WriteLine("Minimum number of moves using iteration: " + Hanoi2(n));
            Console.ReadLine();
        }

        public static int Hanoi(int n)
        {
            if (n == 1) return 1;
            return (2 * (Hanoi(n - 1)) + 1);
        }

        public static int Hanoi2(int n)
        {
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                count = count * 2;
            }
            return count - 1;
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /*
namespace TowersOfHanoi
{
    class TowerOfHanoi
    {
        int discs;

        public TowerOfHanoi()
        {
            Numdiscs = 0;
        }

        public TowerOfHanoi(int newVal)
        {
            Numdiscs = newVal;
        }

        public int Numdiscs
        {
            get
            {
                return discs;
            }
            set
            {
                if (value > 0)
                    discs = value;
            }
        }

        public void MoveTower(int n, int from, int to, int vacant)
        {
            if (n > 0)
            {
                MoveTower(n - 1, from, vacant, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                MoveTower(n - 1, vacant, to, from);
            }
        }
    }

    

    class Gameplay
    {
        public static int Main()
        {
            TowerOfHanoi Tower = new TowerOfHanoi();
            string userNumDiscs;

            Console.Write("Enter the number of discs you wish to play with: ");
            userNumDiscs = Console.ReadLine();
            Tower.Numdiscs = Convert.ToInt32(userNumDiscs);

            Tower.MoveTower(Tower.Numdiscs, 1, 3, 2);
            Console.ReadLine();

            return 0;
        }
    }
}
*/