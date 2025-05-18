using System;

namespace Tripletex.Api;

public class TripletexConfig
{
    public string BaseUrl { get; set; } = "https://api.tripletex.no/";
    public string ConsumerId { get; set; }
    public string EmployeeToken { get; set;}
    public string SessionToken { get; set;}
}
