using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    #region Singleton
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
    #endregion

    [SerializeField]
    private List<QuestDataSO> quests = new List<QuestDataSO>();

    public GameObject questListUiPrefab;

    public Transform questUiParent;

    private void Start()
    {
        foreach (QuestDataSO quest in quests)
        {
            if(quest is MonsterQuestDataSO)
            {
                GameObject questUI = Instantiate(questListUiPrefab, questUiParent);
                questUI.GetComponent<QuestListUI>().SetupQuestData((MonsterQuestDataSO)quest);
            }
            else
            {
                GameObject questUI = Instantiate(questListUiPrefab, questUiParent);
                questUI.GetComponent<QuestListUI>().SetupQuestData((EncounterQuestDataSO)quest);
            }
        }
    }
}
