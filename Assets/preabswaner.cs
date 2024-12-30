using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preabswaner : MonoBehaviour
{
     public GameObject arrowPrefab; // Assign Prefab di Inspector
    public Transform spawnPoint;  // Assign Spawn Point di Inspector
    public float arrowSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space)) // Tekan Space untuk menembak
        {
            SpawnArrow();
        }   
    }
    void SpawnArrow()
    {
        // Spawn prefab
        GameObject arrow = Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
        
        // Tambahkan kecepatan pada Rigidbody
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = spawnPoint.forward * arrowSpeed;
        }
    }
}
