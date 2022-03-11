public enum State
{
    Terkunci,
    Terbuka,
}

public class DoorMachine
{
    private State state = State.Terkunci;

    public void setState(State state)
    {
        this.state = state;
    }

    public void printStatus()
    {
        switch (this.state)
        {
            case State.Terkunci:
                Console.WriteLine("Pintu Terkunci");
                break;
            case State.Terbuka:
                Console.WriteLine("Pintu Tidak Terkunci");
                break;
        }
    }
}
