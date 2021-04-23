using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public static class BoxUISetting
{
    public static GameObject box;
    public static bool boxLock = false;
}

public class BoxController : MonoBehaviour
{
    bool click = false;
    GameObject box;
    Stack<ICommand> undo;
    void Awake()
    {
        box = GameObject.Find("Box1");
        BoxUISetting.box = box;
        undo = new Stack<ICommand>();
    }
    void Update()
    {
        if (BoxUISetting.boxLock == false) { 
            print("boxlock없음");
            if (Input.GetKeyDown(KeyCode.W))
            {
                CommandSetting.Commands[(CommandAction)0].execute(box);
                Debug.Log("press W");
                undo.Push(CommandSetting.Commands[(CommandAction)0].Clone() as ICommand);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                CommandSetting.Commands[(CommandAction)1].execute(box);
                Debug.Log("press A");
                undo.Push(CommandSetting.Commands[(CommandAction)1].Clone() as ICommand);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                CommandSetting.Commands[(CommandAction)2].execute(box);
                Debug.Log("press S");
                undo.Push(CommandSetting.Commands[(CommandAction)2].Clone() as ICommand);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                CommandSetting.Commands[(CommandAction)3].execute(box);
                Debug.Log("press D");
                undo.Push(CommandSetting.Commands[(CommandAction)3].Clone() as ICommand);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                if (undo.Count > 0) { 
                    ICommand temp = undo.Pop();
                    temp.undo();
                }
            }
        }
    }
    private void OnGUI()
    {
        Event keyEvent = Event.current;
        if (click && keyEvent.isKey)
        {
            if(keyEvent.keyCode == KeyCode.Z)
            {
                box = GameObject.Find("Box1");
            }
            else if (keyEvent.keyCode == KeyCode.X)
            {
                box = GameObject.Find("Box2");
            }
            BoxUISetting.box = box;
            click = false;
        }
    }

    public void BoxClicking()
    {
        print("click");
        click = true;
    }

}
