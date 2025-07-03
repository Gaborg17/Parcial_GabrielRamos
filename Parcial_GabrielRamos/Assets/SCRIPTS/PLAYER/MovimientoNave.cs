using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float movementSpeed;

    private float limitXMovement = 8f;

    private float movementX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
        MeshRotation();
    }

    private void Movement()
    {
        movementX = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3 (movementX * movementSpeed, 0, 0);

        Vector3 movementLimit = rb.position;

        movementLimit.x = Mathf.Clamp(movementLimit.x, -limitXMovement,limitXMovement);
        rb.position = movementLimit;
    }

    private void MeshRotation()
    {
        if (movementX == 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else if (movementX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 45f, 0);
        }
        else if(movementX > 0)
        {
            transform.rotation = Quaternion.Euler(0, -45f, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteorito"))
        {
            GameManager.Instance.PlayerDied();
        }
    }




}
