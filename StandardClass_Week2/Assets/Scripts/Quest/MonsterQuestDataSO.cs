using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuest", menuName = "Quest/MonsterQuest")]
public class MonsterQuestDataSO : QuestDataSO
{
    //대상 몬스터 ID
    public int TargetMonsterId;
    //처지 횟수
    public int TargetCount;
}
