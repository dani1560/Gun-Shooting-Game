using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cube (1)" || collision.gameObject.name == "Cube (2)" || 
            collision.gameObject.name == "Cube (3)" || collision.gameObject.name == "Cube (4)" ||
            collision.gameObject.name == "Cube" || collision.gameObject.name == "Plane" ||
            collision.gameObject.name == "Cube (5)" || collision.gameObject.name == "Cube (6)"
            )
        {
            Debug.Log("cameraaa hitssss");
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            bullet.score += 10;
        }
        
    }

}
