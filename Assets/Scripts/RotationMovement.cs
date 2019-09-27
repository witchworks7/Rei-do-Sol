using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Start()
    {
        if (target == null) {
            target = GetComponent<Transform>();
        }
    }

    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}
