namespace Opdracht1.ViewModels
{
    public class User
    {
        private String name { get; set; }
        private int age { get; set; }
        private String email { get; set; }
        private String country { get; set; } = "Belgium";
        private String mobilePhoneNumber { get; set; }

        public User(string name, int age, string email, string country, string mobilePhoneNumber)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.country = country;
            this.mobilePhoneNumber = mobilePhoneNumber;
        }
    }
}
