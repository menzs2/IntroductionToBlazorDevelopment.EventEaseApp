using System.ComponentModel.DataAnnotations;

namespace EventEaseApp;

public class Event
{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Attendees { get; set; } = new List<string>();

}
