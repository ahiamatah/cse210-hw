class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetLengthInMinutes()) * 60;

    public override double GetPace() => GetLengthInMinutes() / _distance;
}
