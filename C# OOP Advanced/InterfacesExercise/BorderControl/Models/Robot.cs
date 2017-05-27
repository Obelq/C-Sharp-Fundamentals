namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            Id = id;
        }
        public string Id { get; set; }
        public string Model { get; set; }
    }
}