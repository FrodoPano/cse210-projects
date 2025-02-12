public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (GetSpeed() * Duration) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / GetSpeed();
}