using TMPro;
using UnityEngine;

public class ContadorMeteoritos : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI contador;

    private void Update()
    {
        contador.text = "Destroyed " + GameManager.Instance.destroyedMeteorites + " Meteorites";
    }

}
