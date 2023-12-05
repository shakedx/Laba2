using System;

public interface ITrafficLightState
{
    void Handle();
}

public class RedState : ITrafficLightState
{
    public void Handle()
    {
        Console.WriteLine("Остановитесь, ждите.");
    }
}

public class GreenState : ITrafficLightState
{
    public void Handle()
    {
        Console.WriteLine("Идите, двигайтесь.");
    }
}

public class TrafficLight
{
    private ITrafficLightState state;

    public TrafficLight()
    {
        state = new RedState();
    }

    public void ChangeState(ITrafficLightState newState)
    {
        state = newState;
    }

    public void Request()
    {
        state.Handle();
    }
}

class Program
{
    static void Main()
    {
        TrafficLight trafficLight = new TrafficLight();

        trafficLight.Request(); 

        trafficLight.ChangeState(new GreenState());
        trafficLight.Request();
    }
}
