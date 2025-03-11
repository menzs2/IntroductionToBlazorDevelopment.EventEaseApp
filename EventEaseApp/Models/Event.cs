using System.ComponentModel.DataAnnotations;

namespace EventEaseApp;

public class Event
{
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
}
