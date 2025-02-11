using UnityEngine;

public class MoveAlongZAxis : MonoBehaviour
{
<<<<<<< HEAD
    public SpeedData speedData;
=======
    public float speed = 5f;
    public SpeedChanger speedChanger;
>>>>>>> origin/main

    public void Update()
    {
        transform.position += new Vector3(0, 0, speedData.speed) * Time.deltaTime;
    }

    public void IncreaseSpeed(float amount)
    {
        speedData.speed += amount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && speedChanger != null)
        {
            speedChanger.ApplySpeed(this);
        }
    }
}