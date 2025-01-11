using UnityEngine;
using UnityEngine.Serialization;

public class Letter : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] LetterSettingsSO letterSettings;

    public void Start()
    {
        rectTransform.sizeDelta = new Vector2(letterSettings.cellSize, letterSettings.cellSize);
    }
}
