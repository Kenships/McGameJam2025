using System;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExpandableLetterBox : MonoBehaviour, IDropHandler
{
    [SerializeField] private LetterSettingsSO settings;
    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    [SerializeField] private RectTransform rectTransform;
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

    private void Update()
    {
        Vector2 deltaSize = new Vector2(Mathf.Max(transform.childCount * settings.cellSize, settings.cellSize), settings.cellSize);
        rectTransform.sizeDelta = deltaSize;
    }
}
