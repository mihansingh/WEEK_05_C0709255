using System;

namespace c0709255
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkOverTheList();
            a.WalkOverTheList();
        }
    }

    class dog
    {
        private static int NumberOfDogs = 0;
        public dog()
        {
            // a constructor is method 
            // that Creates OBJECT FROM TYPE
        }
        public String DogName;
        public String Dogbreed;
        public dog nextDog;
        // jassar

    }
    class LinkedList
    {
        public dog current;
        public dog Head;
        public dog tail;
        public dog Peanut = new dog();
        public dog Fifi = new dog();
        public dog jordan = new dog();
        public dog Fido = new dog();
        public void run()
        {
            Peanut = Head;
            tail = Fido;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.nextDog = fifi;
            Peanut.prevDog = null;

            Fifi.DogName = "fifi";
            Fifi.DogBreed = "poodle";
            Fifi.nextDog = jordan;

            jordan.DogName = "jordan";
            jordan.DogBreed = "germanshepperd";
            jordan.nextDog = Fido;

            Fido.DogName = "fido";
            Fido.DogBreed = "beagle";
            Fido.nextDog = null;

            Fido.DogName = "fifi";
            Fido.DogBreed = "poodle";
            Fido.nextDog = roy;
        }

        public void WalkOverTheList()
        {
            current = Head;
            while (current != null)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;


            }
        }
    }
}
    }

