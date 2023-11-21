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

    // �������������� �� ������� ����������� ����� ���������
    public StatType Type => _statType;

    // ��������� �������� ������
    public int Value => _statValue;

    // ���������� �����������
    public Sprite Icon => _icon;
}
