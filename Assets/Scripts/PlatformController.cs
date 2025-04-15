using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        float rotateX = 0f;
        float rotateZ = 0f;

        if (Input.GetKey(KeyCode.UpArrow)) rotateX = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) rotateX = -1f;
        if (Input.GetKey(KeyCode.LeftArrow)) rotateZ = 1f;
        if (Input.GetKey(KeyCode.RightArrow)) rotateZ = -1f;

        transform.Rotate(rotateX * rotationSpeed * Time.deltaTime, 0f, rotateZ * rotationSpeed * Time.deltaTime);
    }
}
