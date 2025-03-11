namespace EventEaseApp;

    public class ParticipantService
    {
        private readonly List<Participant> participants = new List<Participant>();

        public IEnumerable<Participant> GetParticipants()
        {
            return participants;
        }

        public Participant GetParticipantById(int id)
        {
            return participants?.FirstOrDefault(p => p.Id == id);
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
    }
