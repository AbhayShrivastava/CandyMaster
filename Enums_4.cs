using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// Bonus types
[Flags]
public enum BonusType_4
{
    None,
    DestroyWholeRowColumn,
    DestroyBothWholeRowColumn 
}


public static class BonusTypeUtilities_4
{
   
    /// Helper method to check for specific bonus type
    public static bool ContainsDestroyWholeRowColumn(BonusType_4 bt)
    {
        return (bt & BonusType_4.DestroyWholeRowColumn) 
            == BonusType_4.DestroyWholeRowColumn;
    }

    public static bool ContainsDestroyBothWholeRowColumn(BonusType_4 bt)
    {
        return (bt & BonusType_4.DestroyBothWholeRowColumn)
            == BonusType_4.DestroyBothWholeRowColumn;
    }
}

/// Our simple game state
public enum GameState_4
{
    None,
    SelectionStarted,
    Animating
}
