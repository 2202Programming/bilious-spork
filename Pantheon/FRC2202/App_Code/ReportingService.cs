using System.Collections.Generic;
using System.ServiceModel;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class ReportingService : IReportingService
{
    /// <summary>
    /// The data
    /// </summary>
    Dictionary<string, string> Data = new Dictionary<string, string>();

    /// <summary>
    /// Gets the data.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string GetData(string key)
    {
        return Data[key];
    }

    /// <summary>
    /// Gets the data cache.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<string, string> GetAllData()
    {
        return Data;
    }

    /// <summary>
    /// Reports the data.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <exception cref="NotImplementedException"></exception>
    public void ReportData(string key, string value)
    {
        var temp = Data[key];
        if (temp == null)
            Data.Add(key, value);
        else
            temp = value;
    }
}
