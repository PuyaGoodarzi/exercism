using System;
using System.Linq;
using Xunit.Internal;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = [0, 2, 5, 3, 7, 8, 4];
        return lastWeek; 
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        //int sumVariable = 0;
        //for (int i = 0; i < numberOfDays; i++) 
        //{
        //    sumVariable =+ birdsPerDay[i];
        //}
        //return sumVariable;
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(days => days >= 5);
    }
}
