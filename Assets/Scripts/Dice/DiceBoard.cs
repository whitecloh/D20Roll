using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Окно броска игральной кости
public class DiceBoard : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _checkedStatType;
    [SerializeField]
    private TextMeshProUGUI _checkedStatValue;
    [SerializeField]
    private TextMeshProUGUI _playerStatValue;
    [SerializeField]
    private TextMeshProUGUI _rollResultText;
    [SerializeField]
    private Button _continueButton;

    [SerializeField]
    private Transform _abilityBar;
    [SerializeField]
    private AbilityUI _abilityPrefab;


    private List<AbilitySO> _abilityList;
    private List<AbilityUI> _abiliyUIList;

    private int _sumOfStats;
    private int _needToSuccessValue;

    public int GetStatsSum => _sumOfStats;
    public int GetMinSuccessValue => _needToSuccessValue;

    private void Awake()
    {
        _continueButton.onClick.AddListener(CloseDiceBoard);    
    }

    /// <summary>
    /// Настройка доски с игральной костью D20
    /// </summary>
    /// <param name="statType"> Тип способности </param>
    /// <param name="needToSuccess"> Значение способности для удачного исхода </param>
    /// <param name="abilities"> Все способности игрока типа "statType" </param>
    /// <param name="playerStatsValue"> Значение характеристики типа "statType" у игрока </param>
    public void SetDiceBoard(StatType statType, int needToSuccess, Abilities abilities , int playerStatsValue)
    {
        SetPlayerStatUI(playerStatsValue);
        SetBoardUI(statType, needToSuccess);
        SetAbilityBarUI(abilities, statType);
    }

    private void SetPlayerStatUI(int stats)
    {
        _playerStatValue.text = stats.ToString();
        _sumOfStats += stats;
    }

    private void SetBoardUI(StatType type, int value)
    {
        _checkedStatType.text = type + " Check";
        _checkedStatValue.text = value.ToString();
        _needToSuccessValue = value;
    }

    private void SetAbilityBarUI(Abilities abilities , StatType type)
    {
        _abiliyUIList = new List<AbilityUI>();
        _abilityList = abilities.GetAbilityByType(type);
        foreach (var ability in _abilityList)
        {
            AbilityUI abilityUI = Instantiate(_abilityPrefab, _abilityBar);
            abilityUI.SetAttribute(ability.Value, ability.Type, ability.Icon);
            _abiliyUIList.Add(abilityUI);
            _sumOfStats += ability.Value;
        }
    }

    public void ShowResult(bool isSuccess)
    {
        _rollResultText.gameObject.SetActive(true);
        if(isSuccess)
        {
            _rollResultText.text = "SUCCESS";
            _rollResultText.color = Color.yellow;
        }
        else
        {
            _rollResultText.text = "FAILURE";
            _rollResultText.color = Color.red;
        }
        _continueButton.gameObject.SetActive(true);
    }

    private void CloseDiceBoard()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

}
