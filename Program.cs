using System;

class DNASynthesisProgram
{
    static void Main()
    {
        bool repeatProgram = true;

        while (repeatProgram)
        {
            Console.WriteLine("Enter half of the DNA:");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char confirm = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (confirm == 'Y' || confirm == 'y')
                {
                    string replicatedSequence = ReplicateSequence(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (confirm == 'N' || confirm == 'n')
                {
                    Console.WriteLine("DNA synthesis skipped.");
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char restart = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (restart == 'N' || restart == 'n')
            {
                repeatProgram = false;
            }
            else if (restart != 'Y' && restart != 'y')
            {
                Console.WriteLine("Please input Y or N.");
            }

            Console.WriteLine();
        }
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}
