namespace servisniProtokol;

public class Machine : IHtmlConvertable
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }

    public string ConvertToHtml()
    {
        throw new NotImplementedException();
    }

    public string DefineCss()
    {
        throw new NotImplementedException();
    }
}