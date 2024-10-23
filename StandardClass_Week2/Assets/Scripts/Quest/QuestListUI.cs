using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestListUI : MonoBehaviour
{
    private MonsterQuestDataSO monsterQuestData;
    private EncounterQuestDataSO encounterQuestData;

    public Text questTitleText;
    public Text requiredLevelText;
    public Text questObjectiveText;

    public void SetupQuestData(MonsterQuestDataSO questData)
    {
        monsterQuestData = questData;
        SetUi();
    }

    public void SetupQuestData(EncounterQuestDataSO questData)
    {
        encounterQuestData = questData;
        SetUi();
    }

    private void SetUi()
    {
        if(monsterQuestData != null)
        {
            questTitleText.text = monsterQuestData.QuestName;
            requiredLevelText.text = monsterQuestData.QuestRequiredLevel.ToString();
            questObjectiveText.text = $"{monsterQuestData.TargetMonsterId} �� {monsterQuestData.TargetCount}���� ����";
        }
        else
        {
            questTitleText.text = encounterQuestData.QuestName;
            requiredLevelText.text = encounterQuestData.QuestRequiredLevel.ToString();
            questObjectiveText.text = $"{encounterQuestData.TargetNpcId} �� ��ȭ�ϱ�";
        }
    }
    
}
