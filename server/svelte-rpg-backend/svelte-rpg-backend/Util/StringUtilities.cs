using System.Text;

namespace svelte_rpg_backend.Util;

public class StringUtilities
{

    public static string Hash(string s)
    {
            byte[] data = Encoding.ASCII.GetBytes(s);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            return hash;
    }

    public static bool Compare(string a, string b)
    {
        return a.ToLower() == b.ToLower();
    }
}