using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestData", menuName = "Quset/QusetBase")]
public class QuestDataSO : ScriptableObject
{
    //����Ʈ �̸�
    public string QuestName;
    //����Ʈ ���� �ʿ� ����
    public int QuestRequiredLevel;
    //����Ʈ�� �ִ� NPC ���̵�
    public int QuestNPC;
    //���� ����Ʈ ID ����Ʈ
    public List<int> QuestPrerequisites;
}
