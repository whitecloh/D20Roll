using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField]
    private List<AbilitySO> abilityList;

    /// <summary>
    /// Метод возвращает все способности персонажа , которые дают бонус к характеристике
    /// </summary>
    /// <param name="type"> тип характеристики </param>
    /// <returns> Лист способностей </returns>
    public List<AbilitySO> GetAbilityByType(StatType type)
    {
        var returnedAbilityList = new List<AbilitySO>();

        foreach(var ability in abilityList)
        {
            if(ability.Type==type)
            {
                returnedAbilityList.Add(ability);
            }
        }

        return returnedAbilityList;
    }
}
