using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int destroyedMeteorites;
    public float timeAlive;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    public void PlayerDied()
    {
        timeAlive = 0;
        SceneManager.LoadScene("Juego");
        destroyedMeteorites = 0;
    }

    public void MeteorDestroyed()
    {
        destroyedMeteorites++;
    }


}
