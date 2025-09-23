// See https://aka.ms/new-console-template for more information
using System.Dynamic;

namespace Drone 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); }
    }
}


internal class DeliveryDrone
{
    private String id { get; set; }
    private Double maxWeight { get; set; }
    private Double batteryprecent { get; set; }
    private int altitude { get; set; }
    private String status
    {
        get
        { return status; }
        set
        {
            if (value == "grounded" || value == "inflight" || value == "returninghome")
            {
                status = value;
            }
            else
            {
                throw new ArgumentException("Invalid status value");
            }
        }
    }
    public DeliveryDrone(String id, Double maxWeight)
    {
        this.id = id;
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException("ID cannot be null or empty");
        }
        this.maxWeight = maxWeight;
        if (maxWeight <= 0)
        {
            throw new ArgumentOutOfRangeException("Max weight must be greater than zero");
        }
        this.batteryprecent = 100.0;
        this.altitude = 0;
        this.status = "grounded";

    }
    public DeliveryResult takeoff()
    {
        if (status != "grounded")
        {
            throw new InvalidOperationException("Drone must be grounded to take off");
        }
        if (batteryprecent < 30.0)
        {
            return new DeliveryResult { success = false };
        }
        altitude = 50;
        status = "inflight";
        return new DeliveryResult { success = true };
    }
    public DeliveryResult AssignDelivery(double packageWeight, int distance)
    {
        if (status != "inflight")
        {
            throw new InvalidOperationException("Drone must be in flight to assign a delivery");
        }
        if (packageWeight > maxWeight)
        {
            return new DeliveryResult { success = false };
        }
        if (distance * 5 > batteryprecent)
        {
            return new DeliveryResult { success = false };
        }

        batteryprecent -= distance * 5;
        status = "returninghome";
        return new DeliveryResult { success = true };
    }
    public void Land()
    {
        if (status != "returninghome")
        {
            throw new InvalidOperationException("Drone must be returning home to land");
        }
        altitude = 0;
        status = "grounded";
    }
}
internal class DeliveryResult
    {
        public bool success { get; set; }

    }
