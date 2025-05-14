using UnityEngine;

public class RotateZ : MonoBehaviour
{
    public float rotationSpeed = 45f; 

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}