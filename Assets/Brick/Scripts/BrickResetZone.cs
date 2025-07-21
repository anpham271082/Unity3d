using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class BrickResetZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        BrickGameManager.Instance.OnBallMiss();
    }

}
