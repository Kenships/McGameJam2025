using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LetterSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private LetterSettingsSO settings;
    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    private void Start()
    {
        gridLayoutGroup.cellSize = new Vector2(settings.cellSize, settings.cellSize);
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragDrop letter = dropped.GetComponent<DragDrop>();
        letter.SetParentAfterDrag(transform);
    }
}
