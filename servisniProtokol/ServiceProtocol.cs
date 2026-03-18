namespace servisniProtokol;

public class ServiceProtocol : IHtmlConvertable
{
    public string ProtocolNumber { get; set; }
    public DateTime DateOfMeasurement { get; set; }
    public Customer Customer { get; set; }
    public Machine Machine { get; set; }
    public List<Measurement> Measurements { get; set; }
    
    public bool Compliant()
    {
        throw new NotImplementedException();
    }

    public void Draw(Graphics g)
    {
        throw new NotImplementedException();
    }
    
    public string ConvertToHtml()
    {
        throw new NotImplementedException();
    }
    
    public string DefineCss()
    {
        throw new NotImplementedException();
    }
}