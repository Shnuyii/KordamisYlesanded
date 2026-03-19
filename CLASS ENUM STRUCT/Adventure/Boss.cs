using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Lisa eventsystemile juurde uus event "enemyduel"
Lisa juurde kaks uut klassi, baasklass enemy ja enemyl baseeruv klass Boss
enemyl on omadusteks nimi (string), health (int), elud on enemy puhul algväärtusega 1, bopssil võib rohkem olla (int),
ja catchphrase (string) ning hitpower (int)
boss omab ka andmevälja "BossWeaponName" (string) ja "BossWeaponHitPower" (int)

eventsystemys enemyduel event teostab eventi sees tsüklis kakluse mis kestab
niikaua kuni kas mängijal on elud otsas või enemyl on elud otsas.
juhuarvuga otsustatakse kas vastaseks on üks kolmest enemy objektist (genereeritakse program.csis) või boss.
bossi puhul juhuarvuga otsustatakse kas löök on mööda, boss lööb relvaga või boss lööb käega, tavalise enemy puhul ainult mööda või käega.
kui boss sureb, on mängijal võimalus relv üles võtta.
*/
namespace Adventure
{
    internal class Boss : Enemies
    {
            public string WeaponName { get; set; }
            public int BossWeaponDmg { get; set; }
            public Boss(
                string wepnam,
                int wep,
                string name,
                int hp,
                int lives,
                string msg,
                int dmg)
            {
            WeaponName = wepnam;
            BossWeaponDmg = wep;
            BossName = name;
            BossHp = hp;
            BossLives = lives;
            BossMsg = msg;
            BossDmg = dmg;
            }
    }
}
