namespace simpsons_api.Modules
{
public class Character
{
    string firstName;
    string secondName;
    string lastName;
    int age;
    int height;
    int weight;
    string birthDate;
    string photo;
    string job;
    string description;
public Character(){}



public Character(string firstName)
{
this.firstName
}


        public Character(global::System.String firstName, global::System.String secondName, global::System.String lastName, global::System.Int32 age, global::System.Int32 height, global::System.Int32 weight, global::System.String birthDate, global::System.String photo, global::System.String job, global::System.String description) : this(firstName)
        {
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.birthDate = birthDate;
            this.photo = photo;
            this.job = job;
            this.description = description;
        }

        public string FirstName 
        { 
            get => firstName; 
            set => firstName = value; 
        }
        public string SecondName 
        { 
            get => secondName; 
            set => secondName = value;
         }
        public string LastName 
        { 
            get => lastName; 
            set => lastName = value; 
        }

        public string Age
         { 
             get => age;
             set => age = value;
         }
        public string Height 
        { 
        get => height; 
        set => height = value; 
        }
        public string Weight 
        { 
            get => weight; 
            set => weight = value; 
        }
        public string BirthDate 
        { 
            get => birthDate;
            set => birthDate = value; 
        }
        public string Photo 
        { 
            get => photo; 
            set => photo = value; 
        }
        public string Job 
        { 
            get => job; 
            set => job = value; 
        }
        public string Description 
        {
            get => description; 
            set => description = value; 
         }
    }
}