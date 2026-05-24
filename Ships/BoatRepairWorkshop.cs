namespace Ships;

public class BoatRepairWorkshop
{
    public void RepairBoat(Boat boatForRepair)
    {
        Console.WriteLine("We got the " + boatForRepair.Name + " boat with board number " + boatForRepair.Number + " to repair");
        Console.WriteLine("We are preparing " + boatForRepair.Name + " for repairing");
        Console.WriteLine("We are repairing boat with board number " + boatForRepair.Number);
        Console.WriteLine("We repaired boat with board number " + boatForRepair.Number);
    }
}