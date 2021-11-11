namespace Commander.DTOs
{
    public class CommandReadDTO
    {
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }
        // unecessary to expose this to client
        // public string Platform { get; set; }
    }
}