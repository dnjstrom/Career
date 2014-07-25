using UnityEngine;
using System;

public class Skill : MonoBehaviour
{
    public int worthy;

    int maxValue;
    public int MaxValue
    {
        get { return maxValue; }
        set
        {
            Value = Math.Min(value, Value);
            maxValue = value;
        }
    }

    int currentValue;
    public int Value
    {
        get { return currentValue; }
        set { currentValue = Math.Min(value, maxValue); }
    }

    public Skill(int maxValue)
    {
        this.MaxValue = maxValue;
        this.Value = 0;
    }
    
    public virtual int CalculatePrestige()
    {
        return 0;
    }

    //public abstract int CalculatePrestige();
}