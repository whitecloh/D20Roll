using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability", order = 0)]
public class AbilitySO : ScriptableObject
{
    [SerializeField]
    private Sprite _icon;
    [SerializeField]
    private int _statValue;
    [SerializeField]
    private StatType _statType;

    // Характеристика по которой начисляется бонус владельцу
    public StatType Type => _statType;

    // Численное значение бонуса
    public int Value => _statValue;

    // Визуальное отображение
    public Sprite Icon => _icon;
}
