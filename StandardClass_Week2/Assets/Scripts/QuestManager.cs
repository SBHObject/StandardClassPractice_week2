using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public static QuestManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindAnyObjectByType<QuestManager>();
                if(instance == null)
                {
                    instance = new GameObject("QusetManager").AddComponent<QuestManager>();
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
