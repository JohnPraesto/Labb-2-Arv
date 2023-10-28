namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuckoo cuckoo = new Cuckoo("Africa", "Brown/grey", 0.150, true, false, true, 3);
            HerringGull gull = new HerringGull("Northern Europe", "Grey/white", 1, true, false, false, 16);
            Snake snake = new Snake("World wide", "Any set of colors", 0, true, false, true);
            Cow cow = new Cow("World wide", "Brown/black/white", 300, true, false, true);

            Animal[] animals = { cuckoo, gull, snake, cow };
            Bird[] birds = { cuckoo, gull };

            foreach (Animal item in animals)
            {
                item.AnimalInfo();
            }

            foreach (Animal item in animals)
            {
                item.MakeSound();
            }

            foreach (Bird item in birds)
            {
                item.BirdActivity();
            }
            
            Console.ReadLine();
        }
    }
}