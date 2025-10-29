namespace HandlingExceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // this path works: /Volumes/External/camilapaschini/Developer/CSharp/Fundamentals/HandlingExceptions/Text.txt
            string content = File.ReadAllText("/~/Developer/CSharp/Fundamentals/HandlingExceptions/Text.txt");
            Console.WriteLine(content);
        }
        // try to cover the most common situations, most specific to least specific
        catch (FileNotFoundException) // FileNotFoundException is a subclass of IOException
        {
            Console.WriteLine("File not found...");
        }
        catch (DirectoryNotFoundException) // DirectoryNotFoundException is a subclass of IOException
        {
            Console.WriteLine("Tried to read the file but the directory was not found...");
        }
        catch (IOException) // IOException is a base class for all IO exceptions
        {
            Console.WriteLine("Error reading file...");
        }
        catch (Exception e) // catch all
        {
            Console.WriteLine("Error reading file...");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("This will always run, even when it works.");
        }
    }
}