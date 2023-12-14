using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Rootwire.Hilltop.Domain.Extensions;

public static class StringExtensions
{
    public static string RemoveSpecialCharacters(this string str) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in str) {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_') {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
    
    public static string GenerateEntityIdentifier(this string input)
    {
        if (input == null)
            return null;

        StringBuilder sb = new StringBuilder();
        
        foreach (char c in input)
        {
            // Check for whitespace
            if (char.IsWhiteSpace(c) || c == '_')
            { 
                sb.Append('-'); 
            }
            // else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '-' || c == '.')
            else if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '-') // Keep alphanumeric, hyphens, and underscores

            {
                sb.Append(char.ToLower(c));
            }
            // Other characters are ignored
        }

        // Replace consecutive hyphens with a single hyphen
        string result = Regex.Replace(sb.ToString(), "-{2,}", "-");

        return result;
    }
}