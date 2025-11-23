using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject enemyPrefab;   
    public int numberOfEnemies = 10; 
    public float spawnRadius = 5f;   

    private bool isActivated = false;


    private void OnTriggerEnter(Collider other)
    {
        
        if (!isActivated && other.CompareTag("Player"))
        {
            SpawnEnemies();
            isActivated = true;  
        } 
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }

        Debug.Log($"Spawned {numberOfEnemies} enemies!");
    }
}