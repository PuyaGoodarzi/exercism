class Lasagna
{
    private static int LasagnaExpectedMinutesInOven = 40;

    public int ExpectedMinutesInOven() => LasagnaExpectedMinutesInOven;
    public int RemainingMinutesInOven(int spentMin)
    {
        int remainig = LasagnaExpectedMinutesInOven - spentMin;
        return remainig > 0 ? remainig : 0;
    }

    public int PreparationTimeInMinutes(int layersNum) => (layersNum* 2);
    public int ElapsedTimeInMinutes(int layersNum,int minInOven) => minInOven + (layersNum * 2);

}
