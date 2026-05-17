namespace Ships;

public static class Program
{
    public static void Main(string[] args)
    {
        MilitaryShip militaryShip = new MilitaryShip();
        
        militaryShip.Shoot();
    }
}