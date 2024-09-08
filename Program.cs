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
}