using UnityEngine;

public class DiceAnimation : MonoBehaviour
{
    [SerializeField]
    private Transform _diceRotator;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private DiceBoard _diceBoard;

    private DicePositions _dicePos;

    private int _rollValue;

    private void Awake()
    {
        _dicePos = new DicePositions();
    }

    // �������� ������ ��������� �����
    public void RollDice()
    {
        _animator.SetBool(AnimationsStrings.isDiceRoll, true);
    }

    // �������� ��� ��������� ���� �� ��������� �����
    public void HandleDice(bool isHandle)
    {
        _animator.SetBool(AnimationsStrings.isDiceHandle,isHandle);
    }
    // ��������e ����� - �������� ��������� ����� ����� ������
    public void SetValueAnimator()
    {
        _rollValue = Random.Range(1, 21);
        SetRotation(_rollValue);
    }

    // ����� ����� �� ��������� ����� � ��������� ������
    public void SetFullValue()
    {
        int value = Mathf.Clamp(_rollValue + _diceBoard.GetStatsSum, 1, 20);

        SetRotation(value);
        ShowRollResult(value);
    }

    // ����������� ��������� ����� �� ����������� �������
    public void SetDefaultValue()
    {
        SetRotation(20);
    }

    // ������� ����� ������(value) �����
    private void SetRotation(int value)
    {
        _diceRotator.localRotation = Quaternion.Euler(_dicePos.D20Value[value]);
    }

    // ��������� ������
    private void ShowRollResult(int value)
    {
        if (value >= _diceBoard.GetMinSuccessValue)
        {
            _diceBoard.ShowResult(true);
        }
        else
        {
            _diceBoard.ShowResult(false);
        }
    }
}
