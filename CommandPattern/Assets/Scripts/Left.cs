using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : ICommand
{
    GameObject temp;
    Vector3 prev;
    public void execute(GameObject obj)
    {
        temp = obj;
        prev = obj.transform.position;
        obj.transform.position += new Vector3((float)-0.1, 0, 0);
        return;
    }
    public void undo()
    {
        temp.transform.position = prev;
    }
    public object Clone()
    {
        Down copy = new Down();
        copy.temp = this.temp;
        copy.prev = prev;
        return copy;
    }
}
