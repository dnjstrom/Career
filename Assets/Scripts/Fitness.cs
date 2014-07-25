using UnityEngine;
using System.Collections;
using System;

class Fitness : Skill
{
    public Fitness() : base(20) { }

    public override int CalculatePrestige()
    {
        return (int)Math.Log(worthy / 2 + 1) * 40;
    }

    //public override int CalculatePrestige()
    //{
    //    return (int)Math.Log(Value / 2 + 1) * 40;
    //}
}
