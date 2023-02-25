namespace Kescha.Classes
{
    public abstract class Animal:IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public Animal() { }
        public Animal(string animalName,int animalAge)
        {
            Name = animalName; 
            Age = animalAge;
            CreatedTime= DateTimeOffset.Now;
        }
        
        public Animal(int userAge, int animalAge, string name)
        {
            Age = animalAge;
            Name = name;
            CalculateAgeDifference(userAge);

        }
        // Method Age difference


        public int CalculateAgeDifference(int userAge)
        {
            return AgeDifference = userAge-Age;
        }
        
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name}'s age is {AgeDifference}");

        }

        // Method Compare age

        public void CompareAge(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("You are older ");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("You are equal ");
            }
            else
            {
                Console.WriteLine("You are younger");
            }
        }

        // tell about friends

        public void TellAboutFriends(string userName,int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");
            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge };
            for (int i = 0; i < friendsAge.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old");
            }
        }

        public virtual void Greet(string userName)
        {
            if (userName == "")
            {
                Console.WriteLine("Unknown Person");
            }
            Console.WriteLine($"Hi {userName}!");
        }

        public abstract void Greet2(string userName);
    }
}