using UnityEngine;

public class MoveAlongZAxis : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}