using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnTarget", 0f, spawnInterval);
    }

    void SpawnTarget()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0.5f, 15f);

        GameObject target = Instantiate(targetPrefab, spawnPosition, Quaternion.identity);

        target.GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().material;
    }
}
