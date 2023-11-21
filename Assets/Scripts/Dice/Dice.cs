using UnityEngine;
using UnityEngine.EventSystems;

public class Dice : MonoBehaviour ,IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private DiceAnimation _diceAnimation;

    public void OnPointerClick(PointerEventData eventData)
    {
        _diceAnimation.RollDice();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _diceAnimation.HandleDice(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _diceAnimation.HandleDice(false);
    }
  
}
