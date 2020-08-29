using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class FriendsList : MonoBehaviour

{
    public Animator displayAnim,displayAnim1;

    [Tooltip("the spawning layer")]
    public Button layerFriend;

   public Button butGameObject;
   [Tooltip("the all friends buttons layer")]
    public List<GameObject> btons = new List<GameObject>();

    [Tooltip("just for see the add funct")]
    public InputField nameOfAddingFriend;

   public int i=0;
    Text[] layerTexts;
    public Text displayFriendName;

    public GameObject selectedButton;

    private void Start()
    {
        

        displayFriendName.text = "";
        foreach (Transform child in transform)
        {
            //at the opening add list our friends
            btons.Add(child.gameObject);
        }
    }

    private void Update()
    {
       
      
        //if the friend name is empty we see that text
        if (displayFriendName.text == "")
        {
            displayFriendName.text = "Select a friend";
        }

       
       
        
    }


    public  void AddFriend()
    {
        layerTexts = layerFriend.GetComponentsInChildren<Text>();
        layerTexts[1].text = nameOfAddingFriend.text;
        butGameObject=  Instantiate(layerFriend, transform);
        btons.Add(butGameObject.gameObject);
       
        
    }
  public  void DeleteFriend()
    {
        Destroy(selectedButton);
    }
    public void SelectFriend()
    {
      layerTexts =  EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>();

        

        selectedButton = EventSystem.current.currentSelectedGameObject;

        //set the displayname text, friends buttons nick text
        GameObject.Find("NicknameTextDisplay").GetComponent<Text>().text = layerTexts[1].text;

        displayAnim.SetTrigger("displayAnim");
        displayAnim1.SetTrigger("displayAnim");
    }

    public void InviteFriend()
    {
        Debug.Log("Invıted: "+ displayFriendName.text);
    }  
    public void MessageFriend()
    {
        Debug.Log("Messaged: "+ displayFriendName.text);
    }

}