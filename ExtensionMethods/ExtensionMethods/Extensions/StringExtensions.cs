namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveLastChar(this string instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }

        public static string RemoveLast(this string instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }

        public static string RemoveFirstChar(this string instr)
        {
            return instr.Substring(1);
        }

        public static string RemoveFirst(this string instr, int number)
        {
            return instr.Substring(number);
        }
    }
}
