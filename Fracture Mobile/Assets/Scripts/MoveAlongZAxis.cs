using UnityEngine;

public class MoveAlongZAxis : MonoBehaviour
{
    public float speed = 5f;
    public SpeedChanger speedChanger;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && speedChanger != null)
        {
            speedChanger.ApplySpeed(this);
        }
    }
}