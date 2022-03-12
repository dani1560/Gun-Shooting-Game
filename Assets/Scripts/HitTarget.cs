using UnityEngine;
using UnityEngine.SceneManagement;

public class HitTarget : MonoBehaviour
{  
    GameObject target;
    float[] speed = new float[] { 10f, 25f, 50f};

    void Update()
    {
        target = GameObject.Find("Cube (2)");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed[Random.Range(0, speed.Length)] * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cube (2)")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
