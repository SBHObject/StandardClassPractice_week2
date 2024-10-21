using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private void Update()
    {
        transform.position += Time.deltaTime * 5f * Vector3.right;
    }
}
