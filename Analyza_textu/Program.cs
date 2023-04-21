string opakovani = "a";

while (opakovani == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("****** Analýza textu ******");
    Console.WriteLine("********Tomáš Žižka*********");

    /*string text = "Dnes je je čtvrtek a máme teď IS."; 
    Console.WriteLine(text);
    Console.WriteLine(text[0]);
    Console.WriteLine(text[10]);
    Console.WriteLine(text.Length);*/

    Console.Write("\nZadejte vtsupní text: ");
    string text = Console.ReadLine();

    text = text.ToLower();
    Console.WriteLine("\n==========================================");
    Console.WriteLine("Zadaný text převedený na malá písmena: {0}", text);
    Console.WriteLine("==========================================");

    string samohlasky = "aáeéěiíoóuúůyý";
    string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
    string cislice = "0123456789";

    int pocetSamohlasek = 0;
    int pocetSouhlasek = 0;
    int pocetCislic = 0;
    int ch = 0;
    for (int i = 0; i < text.Length; i++)
    {
        char znak = text[i];
        if (znak == 'c' && i < text.Length - 1 && text[i + 1] == 'h')
        {
            pocetSouhlasek++;
            i++;
            ch++;
        }
        else if (souhlasky.Contains(znak))
            pocetSouhlasek++;
        else if (samohlasky.Contains(znak))
            pocetSamohlasek++;
        else if (cislice.Contains(znak))
            pocetCislic++;
    

        Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
        Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
        Console.WriteLine("Počet číslic: {0}", pocetCislic);
        Console.WriteLine("Počet ostatních znak: {0}", text.Length - pocetSamohlasek - pocetSouhlasek - pocetCislic - ch);

        Console.WriteLine("\nOpakování programu = stisk klávesy a");
        opakovani = Console.ReadLine();
    }
}