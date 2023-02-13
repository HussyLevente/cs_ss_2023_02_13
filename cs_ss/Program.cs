using cs_ss;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<MoHegyei> MoHegyei_List = new List<MoHegyei>();
        static void Main(string[] args)
        {
            Beolvasas();
            Atlag();
            Legnagyobb();
            Bekeres();
        }

        private static void Bekeres()
        {
            Console.Write("adjon meg egy magasságot: ");
            int bekertmagassag = int.Parse(Console.ReadLine());
            bool Igaze = false;
            for (int i = 0; i < MoHegyei_List.Count; i++)
            {
                if (bekertmagassag < MoHegyei_List[i].Magassag && MoHegyei_List[i].Hegyseg == "Börzsöny")
                {
                    Igaze = true;
                    break;
                }
            }
            if (Igaze == true)
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }
        }

        private static void Legnagyobb()
        {
            string legnagyobbhegy = "cecca";
            string legnagyobbhegyseg = "doggo";
            int legnagyobbmagassag = int.MinValue;
            foreach (var m in MoHegyei_List)
            {
                if (legnagyobbmagassag < m.Magassag)
                {
                    legnagyobbmagassag = m.Magassag;
                    legnagyobbhegy = m.HegyCsucsNeve;
                    legnagyobbhegyseg = m.Hegyseg;
                }
            }
            Console.WriteLine($"\nmo legnagyobb hegye: {legnagyobbhegyseg} \nmagassága: {legnagyobbmagassag} \nhegység neve: {legnagyobbhegyseg}");
        }

        private static void Atlag()
        {
            int OsszMag = 0;
            foreach (var m in MoHegyei_List)
            {
                OsszMag += m.Magassag;
            }
            double AtlagMagassag = (double)OsszMag / MoHegyei_List.Count;
            Console.WriteLine($"Mo hegyeinek átlag magassága: {AtlagMagassag:0.00}");
        }

        private static void Beolvasas()
        {
            var sr = new StreamReader(@"hegyekMoSorok.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                var nev = sr.ReadLine();
                var hegycsop = sr.ReadLine();
                var mag = sr.ReadLine();
                db++;
                MoHegyei_List.Add(new MoHegyei(nev, hegycsop, mag));
            }
            sr.Close();
            if (db > 0)
            {
                Console.WriteLine($"\nsikeres beolvasás: {db}");
            }
            else
            {
                Console.WriteLine("\nsikertelen beolvasás");
            }
        }
    }
}