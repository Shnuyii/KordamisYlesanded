namespace Kontrolltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ülesanne 1
            string nimi = "Nipitiri";
            Console.WriteLine("Tere, mis on teie nimi?");
            string nimi2 = Console.ReadLine();
            if (nimi2 != nimi)
            {
                Console.WriteLine("Sisestatud nimi pole õige");
            }

            // Ülesanne 2
            string tulbid = "jah";
            Console.WriteLine("Kas sulle meeldivad tulbid?");
            string vastus = "";
            vastus = Console.ReadLine();
            if (vastus == tulbid)
            {
                Console.WriteLine("mulle kaaa");
            }
            else
            {
                Console.WriteLine("Ei saanud aru, proovi uuesti");
            }

            // Ülesanne 3
            int mängitudTunnid = 0;
            Console.WriteLine("Palju olete viimase nädala jooksul mänginud?");
            mängitudTunnid = int.Parse(Console.ReadLine());
            if (mängitudTunnid == 0)
            {
                Console.WriteLine("Kahju et sul aega mängida pole :c");
            }
            else if (mängitudTunnid > 0 && mängitudTunnid < 10)
            {
                Console.WriteLine("mõõdukas mängija, tubli");
            }
            else if (mängitudTunnid >= 10 && mängitudTunnid < 20)
            {
                Console.WriteLine("natuke paljuks läheb juba, kodutööd kannatavad");
            }
            else if (mängitudTunnid >= 20 && mängitudTunnid < 40)
            {
                Console.WriteLine("liiga palju mängid, kas sa kooli üldse jõuad nii?");
            }
            else if (mängitudTunnid > 40)
            {
                Console.WriteLine("Siin juba peaks sekkuma psühholoog");
            }

            // Ülesanne 4
            int punktid = 0;
            Console.WriteLine("Mitu punkti sa viimases jalgpallimängus said?");
            punktid = int.Parse(Console.ReadLine());
            switch (punktid)
            {
                case 0: Console.WriteLine("PUDRUJALG OLED VÄ?!?!");
                    break;
                    case 1: Console.WriteLine("täitsa ok");
                    break;
                    case 2: Console.WriteLine("no see on juba parem");
                    break;
                    case 3: Console.WriteLine("Wow, messi!");
                    break;
                default: Console.WriteLine("ei tunne sellist skoori, see liiga suur minu jaoks");
                    break;

            }
        }
    }
}
