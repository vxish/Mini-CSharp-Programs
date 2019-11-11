using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyPets
{
    class Person
    {
        public string Name  { get; set; }

        public List<Pet> Pets { get; }

        public int NumberOfPets
        {
            get
            {
                return Pets.Count;
            }
        }

        public Person(string name)
        {
            Name = name;
            Pets = new List<Pet>();
        }

        public bool AddPet(Pet pet)
        {
            bool added = false;
            if (!Pets.Contains(pet))
            {
                Pets.Add(pet);
                added = true;
            }
            return added;
        }

        public bool RemovePet(Pet pet)
        {
            bool removed = false;
            if (Pets.Contains(pet))
            {
                Pets.Remove(pet);
                removed = true;
            }
            return removed;
        }
    }
}
