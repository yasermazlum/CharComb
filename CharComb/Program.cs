namespace CharComb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rnkey = RandomKey();
            string guid = GuidKey();
            Console.WriteLine($"Random Key: {rnkey}");
            Console.WriteLine($"Random Guid: {guid}");
            
        }

        static string RandomKey()
        {
            Random rn = new Random();
            string charset = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = new char[4];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = charset[rn.Next(charset.Length)];
            }
            return new string(chars);
        }

        static string GuidKey()
        {
            Guid gn =  Guid.NewGuid();
            //Console.WriteLine(gn.ToString());
            string key = gn.ToString().Split("-")[0];
            return key;
        }
    }
}