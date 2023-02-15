namespace Cobranza.Core.Models
{
    public class Movement
    {
        public string? Code { get; set; }
        public DateTime DateTime { get; set; }
        public decimal WeekPrice { get; set; }
        public Student? Student { get; set; }
    }
}
