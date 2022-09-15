using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float Spawnrange = 9.0f;
    private GameObject enemyCount;
    public static SpawnManager Instance;
    public List<GameObject> haider;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        haider = new List<GameObject>();
        InvokeRepeating("CallAgain", 1, 15);
        CallAgain();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.Find("Enemy(Clone)");
        if (enemyCount == null)
        {
            Debug.Log("done it");
           GameObject goo = Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            haider.Add(goo);
            CallAgain();
        }
    }
    public Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-Spawnrange, Spawnrange);
        float spawnPosZ = Random.Range(-Spawnrange, Spawnrange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    void CallAgain()
    {
        
            GameObject go =Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            haider.Add(go);
        
    }
    public void Spawning ()
    {

    }


}
