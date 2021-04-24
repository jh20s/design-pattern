using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    static public ObserverManager Instance;

    public delegate void ClickButton();
    private event ClickButton ClickEvent;
    public void ObservClickEvent(ClickButton obs)
    {
        ClickEvent += obs;
    }

    public void ClickMyButton()
    {
        ClickEvent.Invoke();
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

}
