namespace EventEaseApp;

public class ParticipantState
{
    public Participant SelectedParticipant { get; private set; }

    public event Action OnChange;

    public void SetSelectedParticipant(Participant participant)
    {
        SelectedParticipant = participant;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}