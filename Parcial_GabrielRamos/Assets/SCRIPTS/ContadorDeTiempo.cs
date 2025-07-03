using TMPro;
using UnityEngine;

public class ContadorDeTiempo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeDisplay;



    private void Update()
    {
        GameManager.Instance.timeAlive = ((int)Time.time);

        timeDisplay.text = "Tiempo Vivo: " + GameManager.Instance.timeAlive;
    }
}
