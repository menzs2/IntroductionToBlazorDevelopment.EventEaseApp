namespace EventEaseApp;

public class EventService
{

    public List<EventModel> Events { get; set; } = new List<EventModel>();
    private bool _isInitialized;
    public async Task LoadEventsAsync()
    {
        if (_isInitialized)
        {
            return;
        }
        await Task.Delay(100);// Simulate an async operation
        GenerateRandomEvents();
        _isInitialized = true;
    }

    public void AddEvent(EventModel newEvent)
    {
        Events.Add(newEvent);
    }

    public void RemoveEvent(EventModel eventToRemove)
    {
        Events.Remove(eventToRemove);
    }

    private void GenerateRandomEvents()
    {
        for (int i = 1; i <= 50; i++)
        {
            Events.Add(new EventModel
            {
                Id = i,
                Name = $"Event {i}",
                Date = DateTime.Now.AddDays(i),
                Description = $"Description for event {i}",
                Location = $"Location for event {i}",
                EndDate = DateTime.Now.AddDays(i + 1),
                CreatedAt = DateTime.Now,
                Participants = new List<Participant>()
            });
        }
    }
}
