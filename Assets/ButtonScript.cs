using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public FriendsList friendScript;
    Button btn;
    // Start is called before the first frame update
    void Start()
    {

        //get the buttons for onclick func
        friendScript = gameObject.transform.parent.GetComponent<FriendsList>();

        btn = gameObject.GetComponent<Button>();
      
      btn.onClick.AddListener(friendScript.SelectFriend);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
