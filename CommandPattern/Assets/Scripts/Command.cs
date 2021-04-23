using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand : ICloneable
{
    void execute(GameObject obj);
    void undo();
}
