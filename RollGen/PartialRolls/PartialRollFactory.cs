﻿namespace RollGen.PartialRolls
{
    internal interface PartialRollFactory
    {
        PartialRoll Build(int quantity);
        PartialRoll Build(string rollExpression);
    }
}
