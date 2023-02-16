using UnityEngine;

public class ConnectToRope : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!collision.gameObject.GetComponent<HingeJoint2D>())
            {
                Destroy(collision.gameObject.GetComponent<HingeJoint2D>());
                collision.gameObject.AddComponent<HingeJoint2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            }
            
        }
    }
    
}
