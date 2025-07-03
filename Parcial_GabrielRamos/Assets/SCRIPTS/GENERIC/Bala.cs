using UnityEngine;

public class Bala : MonoBehaviour
{
    private float speed = 10f;
    private float rotationSpeed = 50f;

    private void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }

}
