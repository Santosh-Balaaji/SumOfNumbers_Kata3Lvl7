namespace Tests
{
    public static class SequenceSum
    {
        public static string ShowSequence(int n)
        {
            string result = "";
            int sum = 0;
            if (n < 0)
                return n.ToString() + "<0";
            else if (n==0)
            {
                return "0=0";
            }
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    result += (i).ToString()+ " = ";
                    sum += i;

                }
                else
                {
                    result += (i).ToString() + "+";
                    sum += i;
                }
            }

            return result + (sum).ToString();
        }
    }
}