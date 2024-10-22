using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestData", menuName = "Quset/QusetBase")]
public class QuestDataSO : ScriptableObject
{
    //퀘스트 이름
    public string QuestName;
    //퀘스트 진행 필요 레벨
    public int QuestRequiredLevel;
    //퀘스트를 주는 NPC 아이디
    public int QuestNPC;
    //사전 퀘스트 ID 리스트
    public List<int> QuestPrerequisites;
}
