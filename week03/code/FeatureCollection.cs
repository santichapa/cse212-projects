using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Security.Cryptography;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string type { get; set; }
    public Metadata metadata { get; set; }
    public Feature[] features { get; set; }
}

public class Metadata
{
    public long generated { get; set; }
    public string Url { get; set; }
    public string title { get; set; }
    public int status { get; set; }
    public string api { get; set; }
    public long count { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
    public string id { get; set; }
}

public class Properties
{
    public decimal mag { get; set; }
    public string place { get; set; }

    public override string ToString()
    {
        return $"{place} - Mag {mag}";
    }
}

public class Geometry
{
    public string type { get; set; }
    public double[] coordinates { get; set; }
}

