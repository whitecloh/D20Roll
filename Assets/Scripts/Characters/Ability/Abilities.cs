using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField]
    private List<AbilitySO> abilityList;

    /// <summary>
    /// ����� ���������� ��� ����������� ��������� , ������� ���� ����� � ��������������
    /// </summary>
    /// <param name="type"> ��� �������������� </param>
    /// <returns> ���� ������������ </returns>
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
