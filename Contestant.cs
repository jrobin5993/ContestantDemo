using System;

public class Contestant
{
    // Static arrays for talent codes and descriptions
    public static char[] TalentCodes = { 'S', 'D', 'M', 'O' };
    public static string[] TalentDescriptions = { "Singing", "Dancing", "Musical Instrument", "Other" };

    public string Name { get; set; }
    public char TalentCode { get; set; }
    public string TalentDescription { get; private set; }
    public decimal EntryFee { get; protected set; }

    // Property for setting talent code and description
    public void SetTalentCode(char code)
    {
        int index = Array.IndexOf(TalentCodes, code);
        if (index != -1)
        {
            TalentCode = code;
            TalentDescription = TalentDescriptions[index];
        }
        else
        {
            TalentCode = 'I'; // Invalid
            TalentDescription = "Invalid";
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Talent: {TalentDescription}, Entry Fee: {EntryFee:C}";
    }
}