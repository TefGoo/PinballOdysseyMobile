using UnityEngine;
using UnityEngine.EventSystems;

public class UIImmuneArea : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        // Consume the event to block it
        eventData.Use();
    }
}
