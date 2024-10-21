using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pools = new List<GameObject>();
    public int poolSize = 300;

    private void Start()
    {
        //poolSize 만큼 오브젝트 풀 추가
        for(int i = 0; i < poolSize; i++)
        {
            GameObject poolObject = Instantiate(prefab);
            pools.Add(poolObject);
            poolObject.SetActive(false);
        }
    }

    public GameObject Get()
    {
        GameObject returnObject = pools.First();
        pools.Remove(returnObject);

        returnObject.SetActive(true);
        return returnObject;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
        pools.Add(obj);
    }
}
