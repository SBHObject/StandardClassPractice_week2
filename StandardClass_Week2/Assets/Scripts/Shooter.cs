using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public ObjectPooling pool;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject shot = pool.Get("Monster");
            shot.transform.position = this.transform.position;

            StartCoroutine(ReleaseShot(shot));
        }
    }

    IEnumerator ReleaseShot(GameObject shot)
    {
        yield return new WaitForSeconds(2f);

        pool.Release(shot, "Monster");
    }
}
