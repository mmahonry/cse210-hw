public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes() => _minutes;
    public string GetDate() => _date;

    // Métodos que cada actividad debe implementar
    public abstract double GetDistance(); // miles o km
    public abstract double GetSpeed();    // mph o kph
    public abstract double GetPace();     // min por mile/km

    // Método compartido para todas las actividades
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
