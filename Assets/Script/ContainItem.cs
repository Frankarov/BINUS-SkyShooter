using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainItem : MonoBehaviour
{

    public List<ObjectSpawnRate> objects;

    public void spawnItemOnDeath()
    {
        GameObject go = getItem();
        Instantiate(go);
    }

    private GameObject getItem()
    {

        int limit = 0;

        foreach (ObjectSpawnRate osr in objects)
        {
            limit += osr.rate;  
        }

        int random = Random.Range(0, limit);

        foreach (ObjectSpawnRate osr in objects)
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
}
