namespace List._08_Working_with_a_List_of_Custom_Objects
{
    public partial class CustomObject
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }


        }

    }
}
