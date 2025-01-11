using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterSlotHolder : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] GridLayoutGroup gridLayoutGroup;
    [SerializeField] GameObject letterSlotPrefab;
    [SerializeField] private LetterSettingsSO letterSettings;
    [SerializeField] private int numberOfLetters;
    private List<LetterSlot> _letterSlots;
    private void Start()
    {
        _letterSlots = new List<LetterSlot>();
        float height = letterSettings.cellSize;
        float width = height * numberOfLetters;
        
        rectTransform.sizeDelta = new Vector2(width, height);
        
        gridLayoutGroup.cellSize = new Vector2(height, height);

        for (int i = 0; i < numberOfLetters; i++)
        {
            GameObject letterSlot = Instantiate(letterSlotPrefab, transform);
            _letterSlots.Add(letterSlot.GetComponent<LetterSlot>());
        }
    }
}
