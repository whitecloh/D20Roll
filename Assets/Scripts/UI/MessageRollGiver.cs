using UnityEngine;

public class MessageRollGiver :MonoBehaviour
{
    [SerializeField]
    private StatType _statType;
    [SerializeField]
    private int _needToSuccessValue;

    private Player _player;

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
    }
    public void OnClick()
    {
        UIManager.Instance.InitializeDiceBoard(_statType, _needToSuccessValue, _player.GetAbilities , _player.GetStats.GetStatByType(_statType));
    }
}
