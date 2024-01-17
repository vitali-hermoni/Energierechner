using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Energierechner.SharedMethods.Helper;

public class JsonHelper
{
    public static bool IsValidJsonList(string jsonString)
    {
        try
        {
            JArray.Parse(jsonString);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
    }
}
