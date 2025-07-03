using UnityEngine;

public class Meteorito : MonoBehaviour
{
    [SerializeField]
    private float fallingSpeed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector3.down *  fallingSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            GameManager.Instance.MeteorDestroyed();
        }
    }

}
