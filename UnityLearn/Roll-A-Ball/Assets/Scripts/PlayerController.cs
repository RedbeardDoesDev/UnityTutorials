using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private int _count;

    public float Speed;
    public Text CountText, WinText;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

        _count = 0;
        SetCount();

        WinText.text = "YOU WIN!!!!!!";
        WinText.enabled = false;
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
            _count++;
            other.gameObject.SetActive(false);
            SetCount();
        }
    }

    void SetCount()
    {
        CountText.text = "Count: " + _count;

        if (_count == 10)
        {
            WinText.enabled = true;
        }
    }
}
