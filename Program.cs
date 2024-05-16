namespace Week2ChallengeLabs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("C:\\MSSA-CCAD14\\Lab2.txt");
            writer.WriteLine("Hello!! My name is Shawn");
            writer.WriteLine("We are creating a new file");
            writer.Close();

            StreamReader reader = new StreamReader("C:\\MSSA-CCAD14\\Lab2.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            File.Copy("C:\\MSSA-CCAD14\\Lab2.txt", "C:\\MSSA-CCAD14\\Lab2test.txt", true);
            StreamReader reader2 = new StreamReader("C:\\MSSA-CCAD14\\Lab2test.txt");
            string line2 = reader2.ReadLine();
            while (line2 != null)
            {
                Console.WriteLine(line2);
                line2 = reader2.ReadLine();
            
            }

        }

    }   
}
