using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject ballPrefab;
    public Transform spawnPoint;

    private GameObject currentBall;

    public AudioClip winSound;
    public AudioClip loseSound;
    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SpawnBall();
    }

    public void RespawnBall()
    {
        if (loseSound) audioSource.PlayOneShot(loseSound);
        if (currentBall != null)
            Destroy(currentBall);

        Invoke(nameof(SpawnBall), 1f);
    }

    private void SpawnBall()
    {
        currentBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }

    public void WinGame()
    {
        Debug.Log("You Win!");
        if (winSound) audioSource.PlayOneShot(winSound);
        UIManager.Instance.ShowWinText();
        Invoke(nameof(RestartGame), 3f);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
