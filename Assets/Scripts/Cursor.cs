using UnityEngine;

public class MousePointer : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTexture;
    public void Start()
    {
        if (cursorTexture != null)
        {
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }
    }
    
}
