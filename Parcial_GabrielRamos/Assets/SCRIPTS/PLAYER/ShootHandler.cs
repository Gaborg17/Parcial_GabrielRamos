using Unity.VisualScripting;
using UnityEngine;

public class ShootHandler : MonoBehaviour
{
    [SerializeField]
    private Transform shootPoint;

    public GameObject bulletPrefab;

    private float coolDown = 1f;
    private float counter = 0f;


    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        
        if (Input.GetMouseButtonDown(0) && counter <= 0)
        {
            GameObject clone = Instantiate(bulletPrefab,shootPoint.position,shootPoint.rotation);
            Destroy(clone,2);
            counter = coolDown;
            
        }
        counter -= Time.deltaTime;
    }

}
