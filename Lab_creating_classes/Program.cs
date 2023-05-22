﻿using System;

namespace LabCreatingClasses
{
    class Person
    {
        /*Person Object Attributes*/
        public int personalId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        /*Person Object Contructor*/
        public Person(int enterID, string enterFirstName, string enterLastName, string enterColour, int enterAge, bool working)
        {
            this.personalId = enterID;
            this.firstName = enterFirstName;
            this.lastName = enterLastName;
            this.favoriteColour = enterColour;
            this.age = enterAge;
            this.isWorking = working;
        }

        /*Method used to display Person objects first name, last name, personal Id, and thier favorite colour*/
        /*accepts the six person attributes ??? i dont understand why it seems redundant*/
        public void DisplayPersoninfo()
        {
            string Name = ($"{firstName} {lastName}");
            Console.WriteLine($"{personalId}: {Name}'s favorite color is {favoriteColour}\n");
        }
        
        /*Method used to change a person object favorite colour to white*/
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        /*Method used to calculate the person object age after 10 years*/
        public void GetAgeInTenYears() 
        {
            int newAge = age + 10;
            Console.WriteLine($"{firstName} {lastName}'s Age in 10 years is: {newAge}\n");
        }

        /*Method displays all Person object information as a list*/
        public void ToString()
        {
            string displayID = personalId.ToString();
            string displayAge = age.ToString();
            string displayWorking = isWorking.ToString();
            Console.WriteLine($"Personal Id: {displayID}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Favorite Colour is: {favoriteColour}");
            Console.WriteLine($"Age: {displayAge}");
            Console.WriteLine($"Is Working: {displayWorking} \n");        
        }

    }

    class Relation
    {
        /*Relation Object Attribute*/
        public string relationshipType = "No relation";

        /*Relation Object Constructor - checks for valid values*/
        public Relation(string enterRelationshipType)
        {
            if (enterRelationshipType == "Sister")
            {
                this.relationshipType = "Sisterhood";
            }
            if (enterRelationshipType == "Brother")
            {
                this.relationshipType = "Brotherhood";
            }
            if (enterRelationshipType == "Mother")
            {
                this.relationshipType = "Motherhood";
            }
            if (enterRelationshipType == "Father")
            {
                this.relationshipType = "Fatherhood";
            }
        }

        /*Method accepts two Person objects and displays the relationship between them*/
        public void ShowRelationShip(Person personOne, Person personTwo) 
        {
            string relationship = ($"Relation between {personOne.firstName} and {personTwo.firstName} is {relationshipType} \n");
            Console.WriteLine(relationship);
        }
    }

    class MainProgram 
    {
        
        /* Executing the examples from the word document */
        static void Main(string[] args) 
        {
            /* a) Creating four Person objects using the data*/
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            /* b) Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour */
            Gina.DisplayPersoninfo();

            /* c) Display all of Mike’s information as a list */
            Mike.ToString();

            /* d) Change Ian’s Favorite Colour to white, and then print his information as a sentence*/
            Ian.ChangeFavoriteColour();
            Ian.DisplayPersoninfo();

            /* e) Display Mary's age after 10 years*/
            Mary.GetAgeInTenYears();

            /* f) Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.*/
            Relation Sister = new Relation("Sister");
            Relation Brother = new Relation("Brother");
            Sister.ShowRelationShip(Gina, Mary);
            Brother.ShowRelationShip(Ian, Mike);

            /* g) Add all the Person objects to a list, and then use the list to display the following comments */
            Person[] people = new Person[] { Ian, Gina, Mike, Mary };

            /* - The average age of the people in the list */
            double totalAge = 0;
            foreach (Person person in people) 
            {
                totalAge += person.age;
            }
            double averageAge = totalAge / people.Length;
            Console.WriteLine($"Average age is: {averageAge}\n");

            /* - The youngest person and the oldest person */
            foreach (Person person in people) 
            {
                if (person.age == people.Min(person => person.age)) 
                {
                    Console.WriteLine($"The youngest person is: {person.firstName}\n");
                }
                if (person.age == people.Max(person => person.age)) 
                {
                    Console.WriteLine($"The oldest person is: {person.firstName}\n");
                }                                                                                           
            }

            /* - The names of the people whose first names start with M */
            foreach (Person person in people)
            {
                if (person.firstName[0] == 'M')
                {
                    person.ToString();
                }
            }

            /* - The person information of the person that likes the colour blue */
            foreach (Person person in people) 
            {
                if (person.favoriteColour == "Blue")
                {
                    person.ToString();
                }
            }
            
           

          











        }

    }



}
