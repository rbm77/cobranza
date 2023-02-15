namespace Cobranza.Core.Models
{
    public class Student
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public Route? Route { get; set; }
        public Zone? Zone { get; set; }
        public Group? Group { get; set; }

    }
}
