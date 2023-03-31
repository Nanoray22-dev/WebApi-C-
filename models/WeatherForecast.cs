namespace untitled_folder;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}


interface ITest{
    public int Propiedad1 {get; set;}

    void HacerTesting();

}

class ImplementacionesITest : ITest
{
    public IntPtr propiedad1 { get; set;}
    public int Propiedad1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Hacertesting()
    {
        ITest test1 = new ImplementacionesITest();
    }

    public void HacerTesting()
    {
        throw new NotImplementedException();
    }
}