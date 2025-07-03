using UnityEngine;

public class SpawnMeteoritos : MonoBehaviour
{
    public GameObject prefabMeteorito;

    [SerializeField]
    private float spawnRate;
    [SerializeField]
    private float spawnDistance;

    [SerializeField]
    private float xRange;
    [SerializeField] 
    private float yRange;

    private float timeToNextSpawn;

    private void Start()
    {
        timeToNextSpawn = Time.time + spawnRate;
    }

    private void Update()
    {
        if(Time.time >= timeToNextSpawn)
        {
            Spawn();
            timeToNextSpawn = Time.time + spawnRate;
        }
    }

    private void Spawn()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange),Random.Range(yRange, yRange),spawnDistance);

        GameObject fallingMeteor = Instantiate(prefabMeteorito, spawnPosition,Quaternion.identity);
        Destroy(fallingMeteor, 3);
        
    }

}
