using System;

public class AdultContestant : Contestant
{
    public AdultContestant()
    {
        EntryFee = 30.00m;  // Entry fee for adults
    }
    public override string ToString()
    {
        return base.ToString() + " (Category: Adult)";
    }
}
