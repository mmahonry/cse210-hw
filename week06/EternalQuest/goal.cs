public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Mostrar cómo se ve en la lista
    public abstract string GetDetailsString();

    // Para registrar un evento y devolver puntos ganados
    public abstract int RecordEvent();

    // Para guardar en archivo
    public abstract string GetStringRepresentation();
}
