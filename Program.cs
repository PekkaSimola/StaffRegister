using System;

namespace StaffRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sorry men jag vet inte hur man lagrar data i en indexeread lista.
             * Jag tänkte först att skapa en huvudklass där anropen till att skapa
             * och skriva ut personallistan finns. Och sedan en annan klass för
             * rutinerna som skapar, underhåller och möjliggör utskrift av listan.
             * Men eftersom jag inte vet hur data ska sparas för senare användning,
             * blir det hela meningslöst.
             * 
             * Jag vet inte heller hur datavalideringen ska skrivas. Det behövs
             * tal och längdvalidering samt felhantering för detta. Jag har faktiskt
             * sett det någon gång tidigare, men minns inte detaljerna längre.
             * 
             * Sorry för att min kod är ett skämt, men jag har glömt det mesta C# 
             * jag en gång kunnat. Jag behöver helt enkelt repetera. Tyvärr räcker
             * inte den tillgängliga tiden. Istället att skriva ännu mera löjlig kod
             * så fortsätter jag med videorna och återkommer till programmet när jag
             * lärt mig tillräckligt att kunna skriva något vettigt.
             * 
             * Min kod går att kompilera, men det är inte så mycket mer. Men det finns
             * dock något bra med detta. Det lär inte kunna blir sämre framöver.
             */

            string[] sData;
            int i;
            sData = StaffUtilities.AddStaff();
            for (i = 0; i < sData.Length; i += 2)
            {
                Console.WriteLine(sData(i));
                Console.WriteLine(sData(i+1));
            }
        }
    class StaffUtilities
        {
            static public string[] AddStaff()
            {
                string[] sList;
                string sName;
                string salary;

                for (int i = 0; i < 20; i += 2)
                {
                    Console.Write("Ange namn: ");
                    sName = Console.ReadLine();
                    if (sName.Length == 0)
                    {
                        break;
                    }
                    sList(i) = sName;
                    Console.Write("Ange lön för " + sName + ": ");
                    salary = Console.ReadLine();
                    if (salary.Length == 0)
                    {
                        break;
                    }
                    sList(i + 1) = salary;
                }
                return sList;
            }
        }
    }
}
