namespace servisniProtokol;

public class Measurement : IHtmlConvertable
{
    public string Parameter { get; set; }
    public double MeasuredValue { get; set; }
    public string Unit { get; set; }
    public bool Compliant { get; set; }

    public string ConvertToHtml()
    {
        throw new NotImplementedException();
    }

    public string DefineCss()
    {
        throw new NotImplementedException();
    }
}