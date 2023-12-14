using System.Text;

namespace Rootwire.Hilltop.Domain.Test.Helpers;

public static class Utilities
{
    public static string GenerateUtf8Characters()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 0x10FFFF; i++)
        {
            if (Char.IsControl((char)i) || Char.IsSurrogate((char)i))
            {
                continue;
            }

            string utf8String = Char.ConvertFromUtf32(i);

            sb.Append(utf8String);
        }

        return sb.ToString();
    }
}