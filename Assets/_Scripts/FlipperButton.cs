using UnityEngine;
using UnityEngine.EventSystems;

public class FlipperButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool flipperActivated = false;

    public bool IsFlipperActivated()
    {
        return flipperActivated;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        flipperActivated = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        flipperActivated = false;
    }
}
