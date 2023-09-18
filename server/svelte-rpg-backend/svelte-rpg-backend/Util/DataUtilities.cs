namespace svelte_rpg_backend.Util;

public class DataUtilities
{

    public static Dictionary<string, T> ConvertToDictionary<T>(List<T> list, string propertyToKey)
    {
        if (string.IsNullOrEmpty(propertyToKey) || list == null || !list.Any())
        {
            throw new ArgumentException("Invalid input parameters.");
        }
        var propertyInfo = typeof(T).GetProperty(propertyToKey);
        if (propertyInfo == null)
        {
            throw new ArgumentException($"Property '{propertyToKey}' not found in type '{typeof(T).Name}'.");
        }
        var dictionary = new Dictionary<string, T>();
        foreach (var item in list)
        { 
            string? keyValue = propertyInfo.GetValue(item)?.ToString();

            if (!string.IsNullOrEmpty(keyValue) && !dictionary.ContainsKey(keyValue))
            {
                dictionary.Add(keyValue, item);
            }
        }

        return dictionary;
    }
}