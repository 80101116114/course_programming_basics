namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ahoj vítám tě v mém programu!");
                string name = JmenoUzivatele();
                int vek = Vek();
                double vyska = VyskaodUzivatele();
                double vaha = VahaUzivatele();
                //string zprava = Zprava();
                Console.WriteLine(name + " je starý(á) " + vek + " let. Váží " + vaha + " kilogramů a je " + vyska + " centimetrů vysoký(á).");

                double height = vyska / 100;
                double weight = vaha;
                double bmi = CalculateBmiIndex(height, weight);
                double BmiRounded = Math.Round(bmi);
                Console.WriteLine("Vaše bmi je " + BmiRounded);

                if (BmiRounded <= 15)
                {
                    Console.WriteLine("Tohle není úplně zdravé, zkus přibrat");
                }
                else if (BmiRounded >= 15 && BmiRounded <= 45)
                {
                    Console.WriteLine("Mas idealni BMI");
                }
                else
                {
                    Console.WriteLine("Zkus zhubnout");
                }

            }
        public static int Vek()
        {
            Console.Write("Prosim zadej svuj vek");
            string VekUzivatele = Console.ReadLine();
            int VekUzivateleInt = int.Parse(VekUzivatele);
            return VekUzivateleInt;
        }
        public static double CalculateBmiIndex(double height, double weight)
        {
            var bmi = weight / (height * height);
            return bmi;

        }
        public static double VyskaodUzivatele()
        {
            Console.Write("Prosim zadej svou vysku v cm ");
            string vstupVyska = Console.ReadLine();
            double VyskaDouble = double.Parse(vstupVyska);
            return VyskaDouble;
        }
        public static string JmenoUzivatele()
        {
            Console.Write("Prosim zadej sve jmeno ");
            string JmenoUzivatele = Console.ReadLine();
            return JmenoUzivatele;
        }
        public static double VahaUzivatele()
        {
            Console.Write("Prosim zadej svou hmotnost ");
            string VahaUzivatele = Console.ReadLine();
            double VahaUzivateleDouble = double.Parse(VahaUzivatele);
            return VahaUzivateleDouble;
        }
        /*public static string Zprava()
        {
            string zpravaProUzivatele = (JmenoUzivatele() + " je starý(á) " + Vek() + " let. Váží " + VahaUzivatele() + " kilogramů a je " + VyskaodUzivatele() + " centimetrů vysoký(á).");
            Console.WriteLine(zpravaProUzivatele);
            return zpravaProUzivatele;
                }*/


    }
}
        }
    }
}
