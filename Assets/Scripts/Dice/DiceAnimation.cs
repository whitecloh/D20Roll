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

    // Анимация броска игральной кости
    public void RollDice()
    {
        _animator.SetBool(AnimationsStrings.isDiceRoll, true);
    }

    // Анимация при наведении мыши на игральную кость
    public void HandleDice(bool isHandle)
    {
        _animator.SetBool(AnimationsStrings.isDiceHandle,isHandle);
    }
    // Случайноe число - значение игральной кости после броска
    public void SetValueAnimator()
    {
        _rollValue = Random.Range(1, 21);
        SetRotation(_rollValue);
    }

    // Сумма числа на игральной кости и атрибутов игрока
    public void SetFullValue()
    {
        int value = Mathf.Clamp(_rollValue + _diceBoard.GetStatsSum, 1, 20);

        SetRotation(value);
        ShowRollResult(value);
    }

    // Возвращение игральной кости на стандартную позицию
    public void SetDefaultValue()
    {
        SetRotation(20);
    }

    // Поворот кости гранью(value) вверх
    private void SetRotation(int value)
    {
        _diceRotator.localRotation = Quaternion.Euler(_dicePos.D20Value[value]);
    }

    // Результат броска
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
