using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject prefab;
    //private List<GameObject> pools = new List<GameObject>();
    public int poolSize = 300;

    public Dictionary<string, List<GameObject>> pools = new Dictionary<string, List<GameObject>>();

    private void Start()
    {
        CreatePool("Shot", prefab);
    }

    public GameObject Get(string poolName)
    {
        GameObject returnObject;
        if (pools[poolName].Count > 0)
        {
            returnObject = pools[poolName].First();
            pools[poolName].Remove(returnObject);
        }
        else
        {
            returnObject = Instantiate(prefab);
        }

        returnObject.SetActive(true);
        return returnObject;
    }

    public void Release(GameObject obj, string poolName)
    {
        obj.SetActive(false);
        if (pools[poolName].Count < poolSize)
        {
            pools[poolName].Add(obj);
        }
        else
        {
            Destroy(obj);
        }
    }

    public void CreatePool(string poolName, GameObject _prefab)
    {
        pools.Add(poolName, new List<GameObject>());
        //poolSize 만큼 오브젝트 풀 추가
        for (int i = 0; i < poolSize; i++)
        {
            GameObject poolObject = Instantiate(_prefab);
            pools[poolName].Add(poolObject);
            poolObject.SetActive(false);
        }
    }
}
