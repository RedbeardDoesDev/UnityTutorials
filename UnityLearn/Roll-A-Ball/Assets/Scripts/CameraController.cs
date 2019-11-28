using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject PlayerObject;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - PlayerObject.transform.position;
    }

    void LateUpdate()
    {
        transform.position = PlayerObject.transform.position + _offset;
    }
}
