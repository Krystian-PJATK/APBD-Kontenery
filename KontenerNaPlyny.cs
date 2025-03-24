namespace APBD_Kontenery;

// ReSharper disable once IdentifierTypo
public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    bool isDangerous = false;
    
    public void Notify()
    {
        Console.WriteLine("Doszło do niebezpiecznej sytuacji z " + this.getSerialNumber());
    }
}