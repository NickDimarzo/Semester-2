using System;

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
        /*Accepts all attributes ?*/
        public void DisplayPersoninfo() 
        {      
            string displayId = Convert.ToString(personalId);
            Console.WriteLine($"{displayId}: {firstName} {lastName}'s favorite colour is {favoriteColour}");           
        }
        
        /*Method used to change a person object favorite colour to white*/
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        /*Method used to calculate the person object age after 10 years*/
        public int GetAgeInTenYears() 
        {
            int newAge = age + 10;
            return newAge;
        }

        /*Method displays all Person object information as a list*/
        public void ToString()
        {
            string displayID = Convert.ToString(personalId);
            string displayAge = Convert.ToString(age);
            string displayWorking = Convert.ToString(isWorking);
            Console.WriteLine($"Personal Id: {displayID}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Favorite Colour is: {favoriteColour}");
            Console.WriteLine($"Age: {displayAge}");
            if (isWorking == true)
            {
                Console.WriteLine($"Is Working: Yes");
            }
            else
            {
                Console.WriteLine($"Is Working: No");
            }
        }

        public void ToString2()
        {
            string displayID = Convert.ToString(personalId);
            string displayAge = Convert.ToString(age);
            string displayWorking = Convert.ToString(isWorking);

            string[] testList = { displayID, firstName, lastName, favoriteColour, displayAge, displayWorking };

            foreach (string test in testList)
            {
                Console.WriteLine(test);
            }
        }

    }

    class Relation 
    {
        public string relationshipType;

        public Relation(string enterRelationshipType)
        {
            if (enterRelationshipType == "Sister") 
            {
                this.relationshipType = enterRelationshipType;
            }
            if (enterRelationshipType == "Brother")
            {
                this.relationshipType = enterRelationshipType;
            }
            if (enterRelationshipType == "Mother")
            {
                this.relationshipType = enterRelationshipType;
            }
            if (enterRelationshipType == "Father")
            {
                this.relationshipType = enterRelationshipType;
            }
            else 
            {
                this.relationshipType = ("No relation");
            }
        }
    }

    class MainProgram 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine($"Testing");

            Person Test = new Person(24, "Nick", "Dimarzo", "Green", 29, true);

            Console.WriteLine("\nTest 1");
            Test.ToString();
            Console.WriteLine("\nTest 2");
            Test.ToString2();
        }

    }



}
