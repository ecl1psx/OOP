namespace Program;

public class CrossRoad
{
    public void Start()
    {
        var mutex = new Mutex();
        
        var trafficLights = new[] { new TrafficLight("1"), new TrafficLight("2"), new TrafficLight("3"), new TrafficLight("4") };

        foreach (var trafficLight in trafficLights)
        {
            trafficLight.StartProcess(mutex);    
        }
    }
}