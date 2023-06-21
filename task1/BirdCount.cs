public class BirdCount
{
    List<int> _birds = new List<int>();

    public BirdCount(List<int> birds)
    {
        _birds = birds;
    }

    public void SetValue(List<int> birds)
    {
        _birds=birds;
    }

    public void LastWeek()
    {
        System.Console.Write("[");
        foreach (var bird in _birds)
        {
            System.Console.Write($"{bird}, ");
        }
        System.Console.Write("]");
    }
    public void Today()
    {
        System.Console.WriteLine(_birds[_birds.Count - 1]);
    }
    public void IncrementTodaysCount()
    {
        System.Console.WriteLine(_birds[_birds.Count - 1] + 1);
    }

    public bool HasDayWithoutBirds()
    {
        int t = 0;
        foreach (var _bird in _birds)
        {
            if (_bird == 0) { t++; }

        }
        if (t > 0) { return true; } else { return false; }
    }
    public int CountForFirstDays(int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += _birds[i];
        }
        return sum;
    }
    public int BusyDays()
    {
        int t = 0;
        foreach (var _bird in _birds)
        {
            if (_bird >= 5)
            {
                t++;
            }
        }
        return t;
    }
}