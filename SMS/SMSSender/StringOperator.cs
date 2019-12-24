namespace SMS.Win
{
    public static class StringOperator
    {
        public static string Increment(this string number)
        {
            int i = 0;
            var successful = int.TryParse(number, out i);
            if(successful)
            {
                i++;
                number = i.ToString();
                return number;
            }
            return number;
        }

        public static string Reset(this string number)
        {
            return "0";
        }
    }
}
