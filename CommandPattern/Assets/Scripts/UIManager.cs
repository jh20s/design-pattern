using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text[] txt;
    public Text BoxText;
    public Text InputKey;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < txt.Length; i++)
        {
            txt[i].text = CommandUISetting.Commands[(CommandAction)i].ToString();
        }
        BoxText.text = BoxUISetting.box.name;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < txt.Length; i++)
        {
            txt[i].text = CommandUISetting.Commands[(CommandAction)i].ToString();
        }
        BoxText.text = BoxUISetting.box.name;
    }

    private void OnGUI()
    {
        Event keyEvent = Event.current;
        if (keyEvent.keyCode != KeyCode.None)
        {  
            InputKey.text = "지금 입력: " + keyEvent.keyCode.ToString();
        }
    }
}
