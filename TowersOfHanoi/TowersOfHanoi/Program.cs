using System;

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
