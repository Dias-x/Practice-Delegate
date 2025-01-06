
//Deletage erstellen
public delegate bool FilterDelegate(string str);


class Program
{
    static void Main(string[] args)
    {
        List<string> namen = new List<string>()
        {
            "Andre",
            "Horst",
            "Dias",
            "Maria",
            "Alexander"
        };
        
        //Methode Filter namen mit anfangsbuchstabe "H", werden ausgeführt
        List<string> newList = ReturnNewList(namen, StartsWithH);
        
        foreach(string name in newList)
            Console.WriteLine(name);
        
        //Methode Filter namen die länger als 5 buchstaben sind, werden ausgeführt
        List<string> longList = ReturnNewList(namen, LongerThan3);
        
        foreach(string name in longList)
            Console.WriteLine(name);
    }

    //Methode Liste erstellen mit den Implementierungen (Liste und der Delegate)
    static List<string> ReturnNewList(List<string> original, FilterDelegate filterMethod)
    {
        //neue Liste erstellen
        List<string> newList = new List<string>();

        //für jeden str in original 
        foreach (string str in original)
        {
            //wird der Delegate Methode abgrufen und der Name wird zur neue Liste hinzugefügt
            //zur Not nochmals fragen??
            if(filterMethod(str)== true)
                newList.Add(str);
        }
        return newList;
    }

    //Filter Methode, jeder Name mit H wird ausgegeben
    static bool StartsWithH(string str)
    {
        return (str[0] == 'H' || str[0] == 'h');
    }

    static bool LongerThan3(string str)
    {
        return str.Length > 5;
    }
}