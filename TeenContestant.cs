using System;

public class TeenContestant : Contestant
{
    public TeenContestant()
    {
        EntryFee = 20.00m;  // Entry fee for teens
    }
    public override string ToString()
    {
        return base.ToString() + " (Category: Teen)";
    }

}
