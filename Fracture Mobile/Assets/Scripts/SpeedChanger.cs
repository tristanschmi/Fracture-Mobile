using UnityEngine;

[CreateAssetMenu(fileName = "SpeedChanger", menuName = "ScriptableObjects/SpeedChanger", order = 1)]
public class SpeedChanger : ScriptableObject
{
    public float newSpeed;

    public void ApplySpeed(MoveAlongZAxis moveAlongZAxis)
    {
        moveAlongZAxis.SetSpeed(newSpeed);
    }
}