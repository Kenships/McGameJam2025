using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MouseFollowWithVelocity : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f; // Speed at which the object follows the mouse

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mousePosition - transform.position).normalized;
        
        rb.linearVelocity = direction * speed;
    }
}