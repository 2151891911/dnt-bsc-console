class Helper
{
    public int ReturnRandomNumber()
    {
        return new Random().Next(0, 5);
    }

    //git: changed this
    public static int TestMath(int a, int b)
    {
        return a + b;
    }

    //git: change some aspect on feature
    public static int Subtraction(int a, int b)
    {
        return a - b;
    }

}