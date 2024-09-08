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
}
