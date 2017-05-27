namespace BorderControl.Models
{
    public class Pet : IBirthdate
    {
        private string name;
        private string birthdate;
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        
        public string Name { get; set; }

        public string Birthdate { get; set; }
    }
}