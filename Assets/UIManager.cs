using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Tooltip("The current level and next level")]
    public Text levelCurrentText, levelUpText;

    public Image levelBar;

    public Text playerNameText;
    public string playerName;

    public Text selectedFriendNameText;
    public string selectedFriendName;






    public int currentLevel = 5;


    [Tooltip("The exp of player and the level up value")]
    public float levelExp = 100, levelUpExp = 100;


    public Text rankText;
    public string rank;

    public Animator levelUpCurrentAnimation;
    public Animator levelUpBartAnimation;
    public Animator levelComingAnimation;


  

    void Update()
    {
                 //level bar changes
                 levelBar.fillAmount =  levelExp/  levelUpExp;
        if (levelExp >= levelUpExp)
        {
            currentLevel++;
            levelExp = 0;
           

            //level up animation start
            levelUpCurrentAnimation.SetTrigger("levelup");
            levelUpBartAnimation.SetTrigger("levelup");
        }



        //display the levels
        levelCurrentText.text = "Lv." + currentLevel.ToString();
        levelUpText.text = "Lv." + (currentLevel + 1).ToString();

        //display the name of player
        playerNameText.text = playerName;

        //display the rank
        rankText.text = rank;

        //begin the coming next level animation
        if (levelExp > 80)
            levelComingAnimation.SetBool("isPlay", true);
        else
            levelComingAnimation.SetBool("isPlay",false);

    }
}
