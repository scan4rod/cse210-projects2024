using System;

class Program
{
    static Zoo zoo = new Zoo();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\nMain Menu Options: ");
            Console.WriteLine("  1. Zoo Management");
            Console.WriteLine("  2. Quit");
            Console.Write("Select a choice from the main menu: ");
            string opt = Console.ReadLine();

            if (int.TryParse(opt, out choice))
            {
                switch (choice)
                {
                    case 1:
                        ZooManagementMenu();
                        break;

                }
            }

        } while (choice != 2);
    }

    static void ZooManagementMenu()
    {
        int zooChoice;
        do
        {
            Console.WriteLine("\nZoo Management Menu Options: ");
            Console.WriteLine("  1. Add Animal");
            Console.WriteLine("  2. Add Enclosure");
            Console.WriteLine("  3. Add ZooKeeper");
            Console.WriteLine("  4. Add Veterinarian");
            Console.WriteLine("  5. Display Zoo Information");
            Console.WriteLine("  6. Back to Main Menu");

            Console.Write("Select a choice from the zoo management menu: ");
            string opt = Console.ReadLine();

            if (int.TryParse(opt, out zooChoice))
            {
                switch (zooChoice)
                {
                    case 1:
                        AddAnimal();
                        break;
                    case 2:
                        AddEnclosure();
                        break;
                    case 3:
                        AddZooKeeper();
                        break;
                    case 4:
                        AddVeterinarian();
                        break;
                    case 5:
                        DisplayZooInformation();
                        break;
                    case 6:
                        Console.WriteLine("Returning to the main menu.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (zooChoice != 5);
    }

    static void AddEnclosure()
    {
        Enclosure enclosure = new Enclosure();

        Console.Write("Enter Enclosure Capacity: ");
        enclosure.SetCapacity(int.Parse(Console.ReadLine()));

        Console.Write("Enter Enclosure Temperature: ");
        enclosure.SetTemperature(int.Parse(Console.ReadLine()));

        zoo.AddEnclosure(enclosure);
        Console.WriteLine("Enclosure added to the zoo.");
    }

    static void AddAnimal()
    {
        Animal animal = new Animal();

        Console.Write("Enter the name of the animal: ");
        animal.SetName((Console.ReadLine()));

        Console.Write("Enter the age of the animal: ");
        animal.SetAge(int.Parse(Console.ReadLine()));

        Console.Write("Enter the gender of the animal: ");
        animal.SetGender(Console.ReadLine());

        zoo.AddAnimal(animal);
        Console.WriteLine("Animal added to the zoo.");
    }

    static void AddZooKeeper()
    {
        ZooKeeper zooKeeper = new ZooKeeper();

        Console.Write("Enter ZooKeeper Name: ");
        zooKeeper.SetName(Console.ReadLine());

        Console.Write("Enter ZooKeeper Age: ");
        zooKeeper.SetAge(int.Parse(Console.ReadLine()));

        zoo.AddZooKeeper(zooKeeper);
        Console.WriteLine("ZooKeeper added to the zoo.");
    }

    static void AddVeterinarian()
    {
        Veterinarian veterinarian = new Veterinarian();

        Console.Write("Enter Veterinarian Name: ");
        veterinarian.SetName(Console.ReadLine());

        Console.Write("Enter Veterinarian Specialization: ");
        veterinarian.SetSpecialization(Console.ReadLine());

        zoo.AddVeterinarian(veterinarian);
        Console.WriteLine("Veterinarian added to the zoo.");
    }

    static void DisplayZooInformation()
    {
        zoo.DisplayZooInfo();
    }


}