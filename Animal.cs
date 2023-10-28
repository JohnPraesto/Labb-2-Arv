using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Animal
    {
        public string habitat;
        public string color;
        public double weight;
        public bool predator;
        public bool endangered;

        public Animal(string Habitat, string Color, double Weight, bool Predator, bool Endangered)
        {
            this.habitat = Habitat;
            this.color = Color;
            this.weight = Weight;
            this.predator = Predator;
            this.endangered = Endangered;
        }

        public virtual void MakeSound()
        {

        }
        public virtual void AnimalInfo()
        {

        }

        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping");
        }
    }

    class Bird : Animal
    {
        public bool birdOfPassage;
        public Bird (string Habitat, string Color, double Weight, bool Predator, bool Endangered, bool BirdOfPassage) : base(Habitat, Color, Weight, Predator, Endangered)
        {
            this.birdOfPassage = BirdOfPassage;
        }
        public void Fly()
        {
            Console.WriteLine("The bird is flying");
        }
        public virtual void BirdActivity()
        {

        }
    }

    class Cuckoo : Bird
    {
        public int eggsDestroyed;

        public Cuckoo(string Habitat, string Color, double Weight, bool Predator, bool Endangered, bool BirdOfPassage, int EggsDestroyed) : base(Habitat, Color, Weight, Predator, Endangered, BirdOfPassage)
        {
            this.eggsDestroyed = EggsDestroyed;
        }

        public override void AnimalInfo()
        {
            Console.WriteLine($"\nCUCKOO\nHabitat: {habitat}\nColor: {color}\nWeight: {weight}\nPredator: Yes\nEndagered: No\nBird of Passage: Yes\nEggs destroyed: {eggsDestroyed}\n");
        }

        public override void BirdActivity()
        {
            Console.WriteLine("The Cuckoo lays her eggs in other birds nest");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Coo Coo!");
        }
    }

    class HerringGull : Bird
    {
        public int harassNumber;

        public HerringGull(string Habitat, string Color, double Weight, bool Predator, bool Endangered, bool BirdOfPassage, int HarassNumber) : base(Habitat, Color, Weight, Predator, Endangered, BirdOfPassage)
        {
            this.harassNumber = HarassNumber;
        }
        public override void AnimalInfo()
        {
            Console.WriteLine($"\nEUROPEAN HERRING GULL\nHabitat: {habitat}\nColor: {color}\nWeight: {weight}\nPredator: Yes\nEndagered: No\nBird of Passage: No\nPeople harrased: {harassNumber}\n");
        }
        public override void BirdActivity()
        {
            Console.WriteLine("While you leave your table to get a napkin, the Herring Gull dives down on your plate, grabs the hotdog, and flies away.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeal!");
        }
    }

    class Snake : Animal
    {
        bool poisonous;

        public Snake(string Habitat, string Color, double Weight, bool Predator, bool Endangered, bool Poisonous) : base(Habitat, Color, Weight, Predator, Endangered)
        {
            this.poisonous = Poisonous;
        }

        public override void AnimalInfo()
        {
            Console.WriteLine($"\nSNAKE\nHabitat: {habitat}\nColor: {color}\nWeight: {weight}\nPredator: Yes\nEndagered: No\nPoisonous: {poisonous}\n");
        }
        public void Hunt()
        {
            Console.WriteLine("The snake is sneaking around looking for a mouse");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hsssss!");
        }
    }

    class Cow : Animal
    {
        bool hasHorns;
        public Cow(string Habitat, string Color, double Weight, bool Predator, bool Endangered, bool Horns) : base(Habitat, Color, Weight, Predator, Endangered)
        {
            this.hasHorns = Horns;
        }
        public override void AnimalInfo()
        {
            Console.WriteLine($"\nCOW\nHabitat: {habitat}\nColor: {color}\nWeight: {weight}\nPredator: No\nEndagered: No\nHorns: {hasHorns}\n");
        }
        public void Milk()
        {
            Console.WriteLine("The cow is feeding its calf");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Mooo!");
        }
    }
}
