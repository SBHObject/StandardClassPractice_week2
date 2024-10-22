using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestListUI : MonoBehaviour
{
    private QuestDataSO questData;
    public Text questTitleText;
    public Text requiredLevelText;

    public void SetQuestData(QuestDataSO _questData)
    {
        questData = _questData;
        SetUi();
    }

    private void SetUi()
    {
        questTitleText.text = questData.QuestName;
        requiredLevelText.text = questData.QuestRequiredLevel.ToString();
    }
}
