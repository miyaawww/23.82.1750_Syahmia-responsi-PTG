using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab; // Drag prefab ke sini di Inspector
    public Transform spawnPoint; // Tempat spawn
    public float spawnRate = 1f;
    private void Start()
    {
        InvokeRepeating("SpawnArrow", 0f, spawnRate); 
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
