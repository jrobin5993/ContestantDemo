/*
 * Name:            Jaleel Robinson
 * Date:            09-08-2024
 * Description:     FINAL EXAM - Contestant Demo
 * Resource:
 */

using Microsoft.VisualBasic;
using System;

using System;

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
    }
}