using System.Data;

namespace APBD_Kontenery;

public class Kontener
{
    //Properties
    private float totalWeight; //Kg
    private uint height; //cm
    private float containerWeight; //Kg
    private uint depth; //cm
    private float maxWeight; //Kg
    
    //Serial Number KON-C-1
    private char type; //L — płyny; G — gaz; C — chłodniczy
    private uint id; //Musi być unikalne
                     //Do obczajenia https://learn.microsoft.com/en-us/dotnet/api/system.data.uniqueconstraint?view=net-9.0;
                     //Do obczajenia: https://learn.microsoft.com/en-us/dotnet/api/system.guid?view=net-9.0&redirectedfrom=MSDN
    
    //Collection for making sure id-s are unique
    private static Dictionary<uint, bool> usedIDs = new Dictionary<uint, bool>();

    public string getSerialNumber()
    {
        return "KON"+type+id.ToString();
    }
}