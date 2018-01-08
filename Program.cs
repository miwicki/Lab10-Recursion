using System;


class TowerOfHanoi
{
    int discs;

    public TowerOfHanoi()
    {
        numdiscs = 0;
    }

    public TowerOfHanoi(int newVal)
    {
        numdiscs = newVal;
    }

    public int numdiscs
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

}

public void moveTower(int n, int from, int to, int vacant)
{
    if (n > 0)
    {
        movetower(n - 1, from, vacant, to);
        Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
        movetower(n - 1, vacant, to, from);
    }
}

class Gameplay
{
    public static int Main()
    {
        TowerOfHanoi Tower = new TowerOfHanoi();
        string userNumDiscs;

        Console.Write("Enter the number of discs: ");
        cnumdiscs = Console.ReadLine();
        Tower.numdiscs = Convert.ToInt32(userNumDiscs);

        Tower.movetower(T.numdiscs, 1, 3, 2);
        Console.ReadLine();

        return 0;
    }
}
