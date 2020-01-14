using System;
using System.Collections.Generic;
using System.Linq;

namespace _63.uzd_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = new List<Table>
            {
                new Table()
                {
                    Height = 800,
                    Width = 600,
                    Length = 1000
                },
                new Table()
                {
                    Height = 800,
                    Width = 1000,
                    Length = 1200
                },
                new KitchenTable()
                {
                    Height = 750,
                    Width = 600,
                    Length = 1000,
                },
                new StudyTable()
                {
                    Height = 850,
                    Width = 500,
                    Length = 1500,
                }
            };

            foreach (var table in tables)
            {
                Console.WriteLine(table);
            }

            Console.WriteLine(((KitchenTable)tables[2]).Extend());

            Console.WriteLine(((StudyTable)tables[3]).addDrawer());

            // Izmantojot LINQ atrodiet galdus, kuru izmērs atbilst jums interesējošajam.

            var selectedTables = tables.Where(y => y.Length > 1200);

            foreach (var item in selectedTables)
            {
                Console.WriteLine(item);
            }
        }
    }
}
// Izveidot klasi Table. Tai ir jābūt tādiem properties, kā Height, Width utt.. 
// Izveidot divas jaunas klases KitchenTable un StudyTable. 
// Abām šīm klasēm ir jāmantojas no klases Table. 
// Papildināt klasi KitchenTable un StudyTable tikai ar tām piemītošām īpašībām (properties). 
// Piemēram, virtuves galds var būt paplašināms, ka to var izmantot 4 vai 8 cilvēki. 
// Paplašināšanas rezultātā,tai mainās izmēri. 
// Šo paplašināšanu vai samazināšanu var izdarīt tikai izsaucot metodi Extend vai Shrink. 
// Tikai šīs metodes drīkst mainīt galda izmēru. 
// Paplašiniet klasi StudyTable, piemēram, mācību galdos parasti ir šūplādes. 
// Pamatprogrammā uztaisīt vairākus galdus, gan mācību gan virtuves. Pievienojiet viņus vienam sarakstam. 
// Izmantojot LINQ atrodiet galdus, kuru izmērs atbilst jums interesējošajam.