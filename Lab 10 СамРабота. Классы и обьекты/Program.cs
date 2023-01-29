using System;

class Angle
{
    private int gradus;
    private int min;
    private int sec;

    public int Gradus
    {
        get { return gradus; }
        set
        {
            if (value<0)
            {
                gradus = 0;
            }
            else if (value >= 360)
            {
                gradus = 0;
            }
            else
            {
                gradus = value;
            }
        }
    }

    public int Min
    {
        get { return min; }
        set
        {
            if (value < 0)
            {
                min = 0;
            }
            else if (value >= 60)
            {
                min = 0;
            }
            else
            {
                min = value;
            }
        }
    }

    public int Sec
    {
        get { return sec; }
        set
        {
            if (value < 0)
            {
                sec = 0;
            }
            else if (value >= 60)
            {
                sec = 0;
            }
            else
            {
                sec = value;
            }
        }
    }

    public Angle(int gradus, int min, int sec)
    {
        Gradus = gradus;
        Min = min;
        Sec = sec;
    }

    public double ToRadians()
    {
        return (gradus + min / 60.0 + sec / 3600.0) * Math.PI / 180.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Angle angle = new Angle(365, 55, 67);
        Console.WriteLine("Угол в радианах: " + angle.ToRadians());
        Console.ReadKey();
    }
}
