using System.Collections.Generic;

public class PlayerStats
{
    public Dictionary<StatType, int> Stats = new Dictionary<StatType, int>();

    public int GetStatByType(StatType type)
    {
        return Stats[type];
    }
    public void AddStat(StatType type,int value)
    {
        Stats.Add(type, value);
    }
}
