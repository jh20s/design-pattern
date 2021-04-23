using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : ICommand
{
    public GameObject temp;
    public Vector3 prev;
    public void execute(GameObject obj)
    {
        temp = obj;
        prev = obj.transform.position;
        obj.transform.position += new Vector3(0, (float)-0.1, 0);
        return;
    }
    public void undo()
    {
        Debug.Log(temp);
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
