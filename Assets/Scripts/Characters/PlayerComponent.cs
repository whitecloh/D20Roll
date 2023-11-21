using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Abilities _abilities;
    [SerializeField]
    private int _intelligenceStatOnStart;
    [SerializeField]
    private int _strengthStatOnStart;

    private PlayerStats _stats = new PlayerStats();

    public Abilities GetAbilities => _abilities;
    public PlayerStats GetStats => _stats;

    private void Awake()
    {
        InitializeStats();
    }

    private void InitializeStats()
    {
        _stats.AddStat(StatType.Intelligency, _intelligenceStatOnStart);
        _stats.AddStat(StatType.Strength, _strengthStatOnStart);
    }
}
