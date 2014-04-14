using System;

namespace Zooo
{
    class Zoo
    {
        private string petName;
        private string petKind;
        private int petAge;
        private int foodLimit;
        private int petID;
        protected MedicalPackadge animMedicine = new MedicalPackadge();

        public MedicalPackadge  Medecine { get; set; }
        //Свойство только для чтения
        public int PetId     { get { return petID; } }

        public int FoodLimit    { get; set; }

        public string PetName { get; set; }

        public string PetKind   { get; set; }

        public int PetAge   { get; set; }

        public Zoo()
        {
        }

        public Zoo(string name, string kind, int age)
                :this (name, kind, age, 0, 0)
        {
            
        }

        //Присваивание в конструкторе через свойства.
        public Zoo(string name, string kind, int age, int food, int id)
        {
            PetName = name;
            PetKind = kind;
            PetAge = age;
            FoodLimit = food;
            petID = id; //Присваивание полю только для чтения. Через свойство нельзя!
        }

        public double GetMedicine()
        {
            return animMedicine.ComputePayDeduction();
        }

        //Увеличение лимита таже через свойство
        public void Bonus(int amount)
        {
            FoodLimit += amount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", PetName);
            Console.WriteLine("Kind: {0}", PetKind);
            Console.WriteLine("Age: {0}", PetAge);
            Console.WriteLine("FoodLimit; {0}", FoodLimit);
        }
    }
}
