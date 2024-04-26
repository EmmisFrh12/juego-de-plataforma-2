using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementUpdate : MonoBehaviour
{
    public MMAchievementDisplayItem AchievementDisplayPrefab;
    public MMAchievementList mMAchievementList;
    public MMAchievement mMAchievement;
    MMAchievementDisplayItem achievementDisplay;
    public int AchievementsListPosition;



    private void Start()
    {
        achievementDisplay = GetComponent<MMAchievementDisplayItem>();
        print(this.gameObject.name);
        
    }
    void Update()
    {
        mMAchievement = mMAchievementList.Achievements[AchievementsListPosition];
        AchievementNamer(mMAchievement);
    }

    public void AchievementNamer(MMAchievement achievement)
    {
        achievementDisplay.Title.text = achievement.Title;
        achievementDisplay.Description.text = achievement.Description;
        if (achievement.UnlockedStatus)
        {
            achievementDisplay.Icon.sprite = achievement.UnlockedImage;
        }
        else
        {
            achievementDisplay.Icon.sprite = achievement.LockedImage;
        }
        
        if (achievement.AchievementType == AchievementTypes.Progress)
        {
            achievementDisplay.ProgressBarDisplay.gameObject.SetActive(true);
        }
        else
        {
            achievementDisplay.ProgressBarDisplay.gameObject.SetActive(false);
        }

    }
}
