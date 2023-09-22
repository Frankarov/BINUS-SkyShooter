using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Header("Nilai X Kiri dan Kanan Spawner")]
    public float leftX;
    public float rightX;
    public ObjectSpawnRate[] enemies;
    [SerializeField] List<GameObject> enemyList;

    [Header("Delay Waktu Spawn")]
    public int delay;

    void Start()
    {
        enemyList = new List<GameObject>();
        StartCoroutine(spawner());
    }

    private IEnumerator spawner()
    {
        while (true)
        {
            if (MyCode.GameManager.GetInstance().isPlaying == true)
            {
                Spawn();
            yield return new WaitForSeconds(delay);
            }
            else
            {
                yield return new WaitForSeconds(delay);
            }


        }
    }

    public void Spawn()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Random.Range(leftX, rightX);

        enemyList.Add(Instantiate(getEnemy(), newPosition, transform.rotation));
    }
    private GameObject getEnemy()
    {
        int limit = 0;

        foreach (ObjectSpawnRate osr in enemies)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach (ObjectSpawnRate osr in enemies)
        {

            if (random < osr.rate)
            {
                return osr.prefab;

            }
            else
            {
                random -= osr.rate;
            }
        }
        return null;
    }

    public void clearEnemies()
    {
        foreach (GameObject go in enemyList)
        {
            Destroy(go);
        }
        enemyList.Clear();
    }

}
