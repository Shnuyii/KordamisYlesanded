namespace MathInput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm 1
            //int vanus = 0;
            //Console.WriteLine("Tere, alustamiseks palun sisestage oma vanus.");
            //vanus = int.Parse(Console.ReadLine());
            //int aastaarv = 0;
            //Console.WriteLine("Jätkamiseks palun sisestage selle kalendriaasta number.");
            //aastaarv = int.Parse(Console.ReadLine());
            //int sünniaasta = aastaarv - vanus;
            //Console.WriteLine($"Olete sündinud aastal {sünniaasta}.");

            //Programm 2
            //string kasutajaNimi = "";
            //Console.WriteLine("Sisse logimiseks palun sisestage oma nimi.");
            //kasutajaNimi = Console.ReadLine();
            //Console.WriteLine($"Olete edukalt sisse logitud, {kasutajaNimi}");

            //Programm 3




            //* Suunakood *//
            int suunakood = 0; 
            // muutuja "int" on täisarvu muutuja millele määratakse suvaline või vajalik väärtus
            // "suunakood" on täisarvu tüüpi muutuja nimi
            // "=" on omistusoperaator, millega omistatakse täisarvu muutujale "suunakood" peale omistusoperaatorit olev väärtus
            // 0 on omistatav algväärtus, mida omistatakse muutujale "suunakood"
            // ; on lauselõpumärk et tähistada rea lõppu
            Console.WriteLine("Palun sisesta oma suunakood");
            // Console on windowsi süsteemi C# käsurea adresseerimiseks, millega saab teha erinevaid käsurea operatsioone
            // "." on punktile eelneva objekti adresseerimiseks, et saada mingisugune meetod funktsioon mis kirjutatakse peale punkti
            // WriteLine on funktsioon peale punkti mida kasutatakse käsureale teksti, parameetrite või mõlema kuvamiseks
            // () on sulupaar mis omab funktsiooni tööks vajalikku infot
            // "" tähistab sõna andmetüüpi, mis kasutatakse käsureal teksti kuvamiseks
            // "Palun sisesta oma suunakood" on lausemärkide sees olev lause mida kuvatakse käsureal
            suunakood = int.Parse(Console.ReadLine());
            // Parse on teisendusoperaator, mis üritab teisendada ühest andmetüübist punktile eelnevale muutujale sobivasse andmetüüpi
            // ReadLine on käsureal andmete sisestamiseks ja mis loeb käsureale kirjutatud sõna tüüpi andmeid
            if (suunakood > 9999 && suunakood < 100000)
            // if on tingimuslause kaitstud sõna, mis alustab mingit tingimuse esile kutsumist ja määrab mingile tegevusele või oletusele tingimuse, peale mille
            // täitmist if tingimuse sees määratud tegevust täidetakse, vastasel juhul kui if tingimust ei ole täidetud, jätab ta sellele if tingimusele määratud
            // tegevuse vahele ja läheb teise operatsiooni juurde

            // ">" suurem kui on võrdlus mis tähendab et vasakul pool märki olev parameeter või väärtus peab olema suurem kui teisel pool olev väärtus või parameeter

            // && on AND loogiline tehe, mis kasutatakse if tingimuste kirjeldamiseks ja annab "true" väärtuse ainult siis, kui mõlemad tingimused on täidetud

            // "<" väiksem kui on võrdlus mis tähendab et antud parameeter või väärtus peab olema väiksem kui teisel pool võrdusmärki olev väärtus või parameeter
            {
            // {} loogiliste sulgude koodiplokk, mille sees olevat tegevust täidetakse juhul kui if tingimust on täidetud edukalt
                Console.WriteLine("Ahha nüüd tean kus sa elad");
            }
            else if (suunakood <= 9999)
            // else if on tingimuslause, mida kontrollitakse juhul kui else if eelnevale if tingimust ei ole täidetud ja peab alati olema peale if või teist else if
            // tingimust

            // võrdlusoperaator "<=" väiksem kui või võrdne võrdlus määrab et võrdlusele eelnevale väärtusel või parameetril peab olema väärtus väiksem või võrdne
            // peale operaatorile olevale väärtusele või parameetrile
            {
                Console.WriteLine("Üks täht on puudu");
            }
            else
            // else tingimus täidetakse siis kui eelnevaid tingimuslauseid ei ole täidetud ja saab ainult järgneda teistele tingimusoperaatoritele
            {
                Console.WriteLine("Üks täht on üle");
            }

        }
    }
}
