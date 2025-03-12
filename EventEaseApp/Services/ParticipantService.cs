namespace EventEaseApp;

public class ParticipantService
{
    private readonly List<Participant> participants = new List<Participant>();

    private bool _isInitialized;
    public async Task LoadParticipantsAsync()
    {
        if (_isInitialized)
        {
            return;
        }
        await Task.Delay(100);// Simulate an async operation
        GenerateRandomParticipants();
        _isInitialized = true;
    }

    public IEnumerable<Participant> GetParticipants()
    {
        return participants;
    }

    public Participant GetParticipantById(int id)
    {
        return participants?.FirstOrDefault(p => p.Id == id) ?? new Participant();
    }

    public void AddParticipant(Participant participant)
    {
        participants.Add(participant);
    }

    public void RemoveParticipant(int id)
    {
        var participant = GetParticipantById(id);
        if (participant != null)
        {
            participants.Remove(participant);
        }
    }

    public void UpdateParticipant(Participant updatedParticipant)
    {
        var participant = GetParticipantById(updatedParticipant.Id);
        if (participant != null)
        {
            participant.FirstName = updatedParticipant.FirstName;
            participant.LastName = updatedParticipant.LastName;
            participant.Email = updatedParticipant.Email;
            participant.PhoneNumber = updatedParticipant.PhoneNumber;
        }
    }

    //get the next available participant id
    public int GetNewParticipantId() => participants.Any() ? participants.Max(p => p.Id) + 1 : 1;

    private void GenerateRandomParticipants()
    {
        //Generate some participants  - this is just for testing purposes. A real app would get this data from a database
        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Joachim",
            LastName = "Murat",
            Email = "j.murat@napoleonsmarchals.fr"

        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Jean-Baptiste",
            LastName = "Bernadotte",
            Email = "j.bernatotte@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Louis-Nicolas",
            LastName = "Davout",
            Email = "l.davout@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Michel",
            LastName = "Ney",
            Email = "m.ney@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Jean Lannes",
            LastName = "Lannes",
            Email = "j.lannes@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "André",
            LastName = "Masséna",
            Email = "a.massena@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Jean-de-Dieu",
            LastName = "Soult",
            Email = "j.soult@napoleonsmarchals.fr"
        });

        participants.Add(new Participant
        {
            Id = GetNewParticipantId(),
            FirstName = "Pierre",
            LastName = "Augereau",
            Email = "p.augereau@napoleonsmarchals.fr"
        });
    }
}
