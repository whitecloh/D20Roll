using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        UIManager.Instance.OpenCloseDialogueWindow();
    }
}
