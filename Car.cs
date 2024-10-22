using System.Globalization;

namespace App;
class Car
{
    private readonly string _make;
    private readonly string _model;
    private readonly int _year;
    private string _registration;
    private double _value;

    public Car(string make, string model, int year, string registration, double value)
    {
        _make = make;
        _model = model;
        _year = year;
        _registration = registration;
        _value = value;
    }

    public double GetValue()
    {
        return _value;
    }
    public string GetValue(string Locale)
    {
        return _value.ToString("C", CultureInfo.CreateSpecificCulture(Locale));
    }

    public int GetYear()
    {
        return _year;
    }

    public override string ToString()
    {
        return  "Make: " + _make + Environment.NewLine +
                "Model: " + _model + Environment.NewLine +
                "Year: " + GetYear() + Environment.NewLine +
                "Registration: " + _registration + Environment.NewLine +
                "Value: " + GetValue("en-gb");
    }
}