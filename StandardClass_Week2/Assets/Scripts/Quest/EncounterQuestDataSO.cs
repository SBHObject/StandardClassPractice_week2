using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuest", menuName = "Quest/EncounterQuest")]
public class EncounterQuestDataSO : QuestDataSO
{
    //말을 걸어야하는 대상 NPC 의 ID
    public int TargetNpcId;
}
