using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    float xPosition;
    float yPosition;
    public GameObject target;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        xPosition += 3f * Input.GetAxis("Mouse X");
        yPosition -= 2f * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(yPosition, xPosition, 0f);
    }
}
