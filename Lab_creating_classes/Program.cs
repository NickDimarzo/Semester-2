// CPRG 211D
// Lab: Creating Classes
// Nick Dimarzo
// Revision May 26, 2023

using System;
using System.Net.Http.Headers;

namespace LabCreatingClasses
{
    class Person
    {
        //Person Object Attributes
        protected internal int personalId { get; set; }
        protected internal string firstName { get; set; }
        protected internal string lastName { get; set; }
        protected internal string favoriteColour { get; set; }
        protected internal int age { get; set; }
        protected internal bool isWorking { get; set; }

        //Person Object Contructor
        public Person(int enterID, string enterFirstName, string enterLastName, string enterColour, int enterAge, bool working)
        {
            this.personalId = enterID;
            this.firstName = enterFirstName;
            this.lastName = enterLastName;
            this.favoriteColour = enterColour;
            this.age = enterAge;
            this.isWorking = working;
        }

        //Method used to display Person objects first name, last name, personal Id, and thier favorite colour.
        //accepts all six person attributes
        public string DisplayPersoninfo(int displayId, string displayFirst, string displayLast, string displayColour, int displayAge, bool displayWorking )
        {
            string Name = ($"{displayFirst} {displayLast}");
            string displayinfo = ($"\n{displayId}: {Name}'s favorite color is {displayColour}");
            return displayinfo;
        }
        
        //Method used to change a person object favorite colour to white
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";    
        }

        //Method used to calculate the person object age after 10 years
        public string GetAgeInTenYears() 
        {
            int newAge = age + 10;
            string newAgeString = ($"\n{firstName} {lastName}'s Age in 10 years is: {newAge}");
            return newAgeString;
        }

        //Method displays all Person object information as a list
        public override string ToString()
        {
            string personString = ("\nPersonal Id: " + personalId + "\nFirst Name: " + firstName + "\nLast Name: " + lastName + 
                "\nFavorite Color: " + favoriteColour + "\nAge: " + age + "\nIs working: " + isWorking);
            return personString;
        }
    }

    class Relation
    {
        //Relation Object Attribute
        protected internal string relationshipType = "No relation";

        //Relation Object Constructor - checks for valid values
        public Relation(string enterRelationshipType)
        {
            if (enterRelationshipType == "Sister"){ this.relationshipType = "Sisterhood";}

            if (enterRelationshipType == "Brother"){ this.relationshipType = "Brotherhood";}

            if (enterRelationshipType == "Mother"){ this.relationshipType = "Motherhood";}

            if (enterRelationshipType == "Father"){ this.relationshipType = "Fatherhood";}           
        }

        //Method accepts two Person objects and displays the relationship between them
        public string ShowRelationShip(Person personOne, Person personTwo) 
        {
            string relationship = ($"\nRelation between {personOne.firstName} and {personTwo.firstName} is {relationshipType}");
            return relationship;
        }
    }

    class MainProgram 
    {
   
        // Executing the examples from the word document 
        static void Main(string[] args) 
        {
            Console.WriteLine("Program Begins");

            // a) Creating four Person objects using the data
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            // b) Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour 
            Console.WriteLine(Gina.DisplayPersoninfo(Gina.personalId, Gina.firstName, Gina.lastName, Gina.favoriteColour, Gina.age, Gina.isWorking));

            // c) Display all of Mike’s information as a list 
            Console.WriteLine(Mike.ToString());

            // d) Change Ian’s Favorite Colour to white, and then print his information as a sentence
            Ian.ChangeFavoriteColour();
            Console.WriteLine(Ian.DisplayPersoninfo(Ian.personalId, Ian.firstName, Ian.lastName, Ian.favoriteColour, Ian.age, Ian.isWorking));

            // e) Display Mary's age after 10 years
            Console.WriteLine(Mary.GetAgeInTenYears());

            // f) Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.
            Relation Sister = new Relation("Sister");
            Relation Brother = new Relation("Brother");
            Console.WriteLine(Sister.ShowRelationShip(Gina, Mary));
            Console.WriteLine(Brother.ShowRelationShip(Ian, Mike));

            // g) Add all the Person objects to a list, and then use the list to display the following comments: 
            Person[] people = new Person[] { Ian, Gina, Mike, Mary };

            // - The average age of the people in the list 
            double totalAge = 0;
            foreach (Person person in people) 
            {
                totalAge += person.age;
            }
            double averageAge = totalAge / people.Length;
            Console.WriteLine($"\nAverage age is: {averageAge}");

            // - The youngest person and the oldest person 
            foreach (Person person in people) 
            {
                if (person.age == people.Min(person => person.age)) 
                {
                    Console.WriteLine($"\nThe youngest person is: {person.firstName}");
                }
                if (person.age == people.Max(person => person.age)) 
                {
                    Console.WriteLine($"\nThe oldest person is: {person.firstName}");
                }                                                                                           
            }

            // - The names of the people whose first names start with M 
            foreach (Person person in people)
            {
                if (person.firstName[0] == 'M')
                {
                    Console.WriteLine(person.ToString());
                }
            }

            // - The personal information of the person that likes the colour blue 
            foreach (Person person in people) 
            {
                if (person.favoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
