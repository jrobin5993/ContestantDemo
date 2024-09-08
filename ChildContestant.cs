using System;

public class ChildContestant : Contestant
{
    public ChildContestant()
    {
        EntryFee = 15.00m;  // Entry fee for children
    }

    public override string ToString()
    {
        return base.ToString() + " (Category: Child)";
    }
}
