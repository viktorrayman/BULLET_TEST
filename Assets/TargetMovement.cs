using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 10), transform.position.y, transform.position.z);
    }
}
