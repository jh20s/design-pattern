using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CommandAction { UP, LEFT, DOWN, RIGHT, COUNT };

public static class CommandUISetting
{
    public static Dictionary<CommandAction, string> Commands = new Dictionary<CommandAction, string>();
}

public static class CommandSetting
{
    public static Dictionary<CommandAction, ICommand> Commands = new Dictionary<CommandAction, ICommand>();
}


public class CommandManager : MonoBehaviour
{
    public static int command = -1;
    string[] CommandKeys = new string[] { "UP", "LEFT", "DOWN", "RIGHT"};
    ICommand[] CommandsList = new ICommand[] { new Up(), new Left(), new Down(), new Right()};
    void Awake()
    {

        for (int i = 0; i < (int)CommandAction.COUNT; i++)
        {
            CommandUISetting.Commands.Add((CommandAction)i, CommandKeys[i]);
            CommandSetting.Commands.Add((CommandAction)i, CommandsList[i]);
        }
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        Event keyEvent = Event.current;
        if (command != -1 && keyEvent.isKey)
        {
            if (keyEvent.keyCode == KeyCode.W)
            {
                CommandUISetting.Commands[(CommandAction)command] = CommandKeys[0];
                CommandSetting.Commands[(CommandAction)command] = CommandsList[0];
            }
            else if (keyEvent.keyCode == KeyCode.A)
            {
                CommandUISetting.Commands[(CommandAction)command] = CommandKeys[1];
                CommandSetting.Commands[(CommandAction)command] = CommandsList[1];
            }
            else if (keyEvent.keyCode == KeyCode.S)
            {
                CommandUISetting.Commands[(CommandAction)command] = CommandKeys[2];
                CommandSetting.Commands[(CommandAction)command] = CommandsList[2];
            }
            else if (keyEvent.keyCode == KeyCode.D)
            {
                CommandUISetting.Commands[(CommandAction)command] = CommandKeys[3];
                CommandSetting.Commands[(CommandAction)command] = CommandsList[3];
            }
            print("box lock 해제");
        }
    }
    public void ChangeCommand(int num)
    {
        print("box lock 생성");
        if(command == num)
        {
            command = -1;
            BoxUISetting.boxLock = false;
        }
        else
        {
            command = num;
            BoxUISetting.boxLock = true;
        }
    }  
}
