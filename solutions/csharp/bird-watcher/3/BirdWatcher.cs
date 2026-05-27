class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
         int[] birdsPerDayLastWeek = {0,2,5,3,7,8,4};
        return birdsPerDayLastWeek;
    }

    public int Today()=> birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] = birdsPerDay[birdsPerDay.Length - 1] + 1; 
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int day in birdsPerDay){
            if (day == 0) {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        for(int i=0; i < numberOfDays; i++){
            birdCount += birdsPerDay[i];
        }
        return birdCount;
    }

    public int BusyDays()
    {
        int busyDayCount = 0;
        foreach(int day in birdsPerDay){
            if (day >= 5){
                busyDayCount++;
            }
        }
        return busyDayCount;
    }
}
