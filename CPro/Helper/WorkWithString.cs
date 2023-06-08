using System.Text;

namespace CPro_1.Helper
{
    public static class WorkWithString
    {

        public static string RegistersFirstUpString(string value)
        {
            if(string.IsNullOrEmpty(value))
                return value;

            return value[0].ToString().ToUpper() + value.Substring(1).ToString().ToLower();
        }
    }
}
