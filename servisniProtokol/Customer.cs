namespace servisniProtokol;

public class Customer : IHtmlConvertable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PSC { get; set; }
    public string IC { get; set; }

    public string ConvertToHtml()
    {
        return "";
    }

    public string DefineCss()
    {
        return "";
    }
}