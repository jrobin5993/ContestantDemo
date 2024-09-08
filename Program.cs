/*
 * Name:            Jaleel Robinson
 * Date:            09-08-2024
 * Description:     FINAL EXAM - Contestant Demo
 * Resource:
 */

using Microsoft.VisualBasic;
using System;

using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

public class ContestantDemo
{
    static void Main(string[] args)
    {
        int numContestants = GetNumberOfContestants();
        Contestant[] contestants = new Contestant[numContestants];
        decimal totalRevenue = 0;

        for (int i = 0; i < numContestants; i++)
        {
            contestants[i] = CreateContestant();
            totalRevenue += contestants[i].EntryFee;
        }

        Console.WriteLine($"\nTotal expected revenue: {totalRevenue:C}\n");

        DisplayTalentCategories();

        while (true)
        {
            Console.WriteLine("\nEnter a talent code to list contestants (or 'X' to exit): ");
            char talentCode = GetTalentCode();
            if (talentCode == 'X') break;

            DisplayContestantsByTalent(contestants, talentCode);
        }
    }
    // Get a valid number of contestants (0 to 30)
    static int GetNumberOfContestants()
    {
        int numContestants;
        do
        {
            Console.Write("Enter the number of contestants (0-30): ");
        } while (!int.TryParse(Console.ReadLine(), out numContestants) || numContestants < 0 || numContestants > 30);
        return numContestants;
    }

    // Create contestant based on age
    static Contestant CreateContestant()
    {
        Console.Write("Enter contestant's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter contestant's age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Talent codes: (S)inging, (D)ancing, (M)usical Instrument, (O)ther");
        char talentCode = GetTalentCode();

        Contestant contestant;

        // Determine the type of contestant based on age
        if (age <= 12)
        {
            contestant = new ChildContestant();
        }
        else if (age <= 17)
        {
            contestant = new TeenContestant();
        }
        else
        {
            contestant = new AdultContestant();
        }

        contestant.Name = name;
        contestant.SetTalentCode(talentCode);

        return contestant;
    }
    // Get a valid talent code
    static char GetTalentCode()
    {
        char talentCode;
        do
        {
            Console.Write("Enter talent code: ");
            talentCode = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (Array.IndexOf(Contestant.TalentCodes, talentCode) == -1 && talentCode != 'X');
        return talentCode;
    }
}