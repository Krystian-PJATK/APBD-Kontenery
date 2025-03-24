namespace APBD_Kontenery;

public class KontenerNaGaz : Kontener, IHazardNotifier
{
    private float pressure;

    public void Notify()
    {
        Console.WriteLine("Doszło do niebezpiecznej sytuacji z " + this.getSerialNumber());
    }
}