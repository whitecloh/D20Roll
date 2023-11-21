using UnityEngine;
using UnityEngine.EventSystems;

public class InteractComponent : MonoBehaviour
{
    [SerializeField]
    private LayerMask _interactable;

    private void Update()
    {
        OnInteract();
    }
    private void OnInteract()
    {
        if(Input.GetMouseButtonDown(0)&&!EventSystem.current.IsPointerOverGameObject())
        {
            Ray agentRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(agentRay, out hitInfo, 500, _interactable))
            {
                hitInfo.collider.GetComponent<NPC>().Interact();
            }
        }
    }

}
