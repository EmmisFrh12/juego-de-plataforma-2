using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAchievements : MonoBehaviour
{
    [SerializeField] MMAchievementList list;
    void ResetAchievementsFuntion()
    {
        list.ResetAchievements();
    }
}
