using UnityEngine;
using System.Collections;

public class spawns : MonoBehaviour {

    public Transform[] Spawns;
    public GameObject Inimigos;
    public float spawnTime = 5f;
    public float spawnDelay = 3f;

    public void Start()
    {
        InvokeRepeating("SpawnInimigos", spawnDelay, spawnTime);
    }

    void SpawnInimigos()
    {
        int spawnIndex = Random.Range(0, Spawns.Length);
        Instantiate(Inimigos, Spawns[spawnIndex].position, Spawns[spawnIndex].rotation);
    }
}
