using TMPro;
using UnityEngine;

public class ContadorDeTiempo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeDisplay;



    private void Update()
    {
        GameManager.Instance.timeAlive += Time.deltaTime;

        timeDisplay.text = "Tiempo Vivo: " + ((int)GameManager.Instance.timeAlive);
    }
}
