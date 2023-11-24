static void Main (string [] args)
{


    string fileName = args[0];

    FileStream stream = new FileStream(fileName, FileMode.Open);
    StreamReader reader = new StreamReader(stream);


    int size = (int)stream.Length;

    char[] contents = new char[size];


    for (int i = 0; i< size; i++)
    {
        contents[i] = (char)reader.Read();

    }

    foreach (char ch in contents)
    {
        Console.WriteLine(ch);
    }

    reader.Close();




    FileDetails.Summarize(contents);



}


class FileDetails
{
    public static void Summarize (char [] array)
    {

        int vowels = 0, consonants = 0, lines = 0;

        foreach (char current in array)
        {
            if (Char.IsLetter(current))
            {
                if ("AEIOUaeiou".IndexOf(current)!=-1)
                {
                    vowels++;
                } else
                {
                    consonants++;

                } 
            } else if (current== '\n')
            {
                lines++;
            }
        }

        Console.WriteLine($"Общее количество символов в файле {array.Length}");
        Console.WriteLine($"Общее количество гласных в файле {vowels}");
        Console.WriteLine($"Общее количество согласных в файле {consonants}");
        Console.WriteLine($"бщее количество строк в файле {lines}");
       
    }
}
