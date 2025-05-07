using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamageBoss : MonoBehaviour
{
    public GameObject enemyPrefab; // Spawnlanacak düşman prefabı
    public Transform[] spawnPoints; // Düşmanların spawnlanacağı noktalar
    public int numberOfEnemiesToSpawn = 5; // Spawnlanacak düşman sayısı
    private bool hasSpawned = false; // Spawn işleminin yapılıp yapılmadığını kontrol eder

    Animator animator;

    int x=0; 
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(x);
        if (other.tag == "Melee")
            x++;
        switch(x)
        {
            case 4:
                SpawnEnemies();
                hasSpawned = true;
                break;
            case 5:
                hasSpawned = false;
                break;
            case 8:
                SpawnEnemies();
                hasSpawned = true;
                break;
            case 9:
                hasSpawned = false;
                break;
            case 12:
                SpawnEnemies();
                hasSpawned = true;
                break;
            case 13:
                hasSpawned = false;
                break;
            case 16:
                SpawnEnemies();
                hasSpawned = true;
                break;
            case 17:
                hasSpawned = false;
                break;
        } 
        if (x==20){
            animator.SetTrigger("Die");
            GetComponent<EnemyAI>().enabled = false;
        }
            
    }
    private void SpawnEnemies()
    {
        if(hasSpawned == false){
            for (int i = 0; i < numberOfEnemiesToSpawn; i++)
            {
                int spawnPointIndex = Random.Range(0, spawnPoints.Length);
                Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
        }
        
    }
}