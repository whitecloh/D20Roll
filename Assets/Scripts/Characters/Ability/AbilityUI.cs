using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Атрибут предмета
public class AbilityUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _abilityValue;
    [SerializeField]
    private TextMeshProUGUI _abilityType;
    [SerializeField]
    private Image _icon;


    // Инициализация способности в UI
    public void SetAttribute(int value , StatType type , Sprite icon)
    {
        _abilityType.text = type.ToString();
        _abilityValue.text = value.ToString();
        _icon.sprite = icon;
    }
}
