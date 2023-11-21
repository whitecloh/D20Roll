using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private DiceBoard _diceBoardPrefab;
    [SerializeField]
    private Window _dialogueWindow;
    private DiceBoard _diceBoard;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void InitializeDiceBoard(StatType attributeName, int attributeValue, Abilities inventory , int playerStatsValue)
    {
        _diceBoard = Instantiate(_diceBoardPrefab,Camera.main.transform);
        _diceBoard.SetDiceBoard(attributeName, attributeValue, inventory , playerStatsValue);
        OpenCloseDialogueWindow();
    }

    public void OpenCloseDialogueWindow()
    {
        _dialogueWindow.OpenClose();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
