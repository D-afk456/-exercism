public class SpaceAge
{
    private const double SecondsInEarthYear = 31557600.0;

    private readonly double seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    private double AgeOn(double orbitalPeriod)
    {
        return seconds / (SecondsInEarthYear * orbitalPeriod);
    }

    public double OnEarth() => AgeOn(1.0);

    public double OnMercury() => AgeOn(0.2408467);

    public double OnVenus() => AgeOn(0.61519726);

    public double OnMars() => AgeOn(1.8808158);

    public double OnJupiter() => AgeOn(11.862615);

    public double OnSaturn() => AgeOn(29.447498);

    public double OnUranus() => AgeOn(84.016846);

    public double OnNeptune() => AgeOn(164.79132);
}