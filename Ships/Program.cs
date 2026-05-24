namespace Ships;

public static class Program
{
    public static void Main()
    {
        Submarine submarine = new Submarine();
        SubmarineMaintenanceFactory submarineMaintenanceFactory = new SubmarineMaintenanceFactory();
        
        submarineMaintenanceFactory.Maintain(submarine);

        NuclearSubmarine nuclearSubmarine = new NuclearSubmarine();
        
        submarineMaintenanceFactory.Maintain(nuclearSubmarine);
    }
}