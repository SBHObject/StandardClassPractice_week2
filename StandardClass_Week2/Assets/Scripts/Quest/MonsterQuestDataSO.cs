using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuest", menuName = "Quest/MonsterQuest")]
public class MonsterQuestDataSO : QuestDataSO
{
    //��� ���� ID
    public int TargetMonsterId;
    //ó�� Ƚ��
    public int TargetCount;
}
