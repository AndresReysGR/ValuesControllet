namespace web_api_simpsons.Modules
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
        string jop;
        string description;

        public Character(){}

        //nombre de la clase dejas el cursosr y te hce un constructor
        public Character(string firstName, string secondName, string lastName, int age, int height, int weight, string birthDate, string photo, string jop, string description)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.birthDate = birthDate;
            this.photo = photo;
            this.jop = jop;
            this.description = description;
        }


//Clic en seleccionar todo los int/strin"caracteristicas" saldra un bombillo
//y clic derecho y selecciona "Encapsular, pero seguir usando campos"
        public string FirstName 
        { 
            get => firstName; 
            set => firstName = value;
        }
        //esto se hace para entender mejor, aun que no es la manera correta de hacer
        public string SecondName 
        {
             get => secondName; 
             set => secondName = value; 
        }
        //es lo mismo que esto
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Jop { get => jop; set => jop = value; }
        public string Description { get => description; set => description = value; }


    }
}