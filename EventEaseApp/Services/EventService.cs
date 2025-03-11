﻿namespace EventEaseApp;

public class EventService
{

    public List<Event> Events { get; set; } = new List<Event>();

    public async Task LoadEventsAsync()
    {
        Events = new List<Event>();
        await Task.Delay(2);
        for (int i = 1; i <= 50; i++)
        {
            Events.Add(new Event
            {
                Id = i,
                Name = $"Event {i}",
                Date = DateTime.Now.AddDays(i),
                Description = $"Description for event {i}",
                Location = $"Location for event {i}",
                EndDate = DateTime.Now.AddDays(i + 1),
                CreatedAt = DateTime.Now
            });
        }
    }

    public void AddEvent(Event newEvent)
    {
        Events.Add(newEvent);
    }

    public void RemoveEvent(Event eventToRemove)
    {
        Events.Remove(eventToRemove);
    }
}
