using UnityEngine;

public class ObjectSwing : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 0.4f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        rb.AddForce(Vector2.Lerp(Vector2.right, Vector2.left, Mathf.Sin(Time.timeSinceLevelLoad)) * moveSpeed);
    }
}
