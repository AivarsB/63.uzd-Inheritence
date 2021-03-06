﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _63.uzd_Inheritence
{
    public class Table
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"{Height}x{Width}x{Length}";
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
// Pamatprogrammā uztaisīt vairākus galdus, gan mācību gan v tuves. Pievienojiet viņus vienam sarakstam. 
// Izmantojot LINQ atrodiet galdus, kuru izmērs atbilst jums interesējošajam.