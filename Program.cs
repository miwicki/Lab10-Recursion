using System;
class Classes
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

