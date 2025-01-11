using UnityEngine;
using UnityEngine EventSystems;

public class MenuContainerScript : MonoBehaviour, IDragHandler
{
  public Canvas DraggableMenu;
  
  private RectTransform rectTransform;

  void Start()
    {
      rectTranform = GetComponent<RectTranform>();
    }

  void IDragHandler OnDrag(PointerEventData eventData)
}
