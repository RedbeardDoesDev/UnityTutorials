using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidBody;

    public float Speed;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        _rigidBody.AddForce(new Vector3(moveHorizontal, 0f, moveVertical) * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
