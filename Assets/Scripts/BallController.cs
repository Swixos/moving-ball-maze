using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap") || transform.position.y < -5f)
        {
            GameManager.Instance.RespawnBall();
        }

        if (other.CompareTag("Goal"))
        {
            GameManager.Instance.WinGame();
        }
    }
}