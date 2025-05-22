using UnityEngine;

public class basicmovementlab : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);
    }

    // Called when the object is no longer visible by any camera
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
