using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 originalPos;
    Quaternion originalRot;

    void Start()
    {
        originalPos = gameObject.transform.position;
        originalRot = gameObject.transform.rotation;
    }

    void FixedUpdate()
    {
        OutOfBound();
    }

    void OutOfBound()
    {
        if (transform.position.y < 0)
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep();
        }
    }

    void OnCollisionEnter (Collision collisionInfo) //Collision: ?? cho Unity bi?t ta mu?n thu th?p thông tin khi va ch?m
    {
        if (collisionInfo.collider.tag == "Dinosaurus")
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep();
        }
        if (collisionInfo.collider.name == "EndPoint")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
