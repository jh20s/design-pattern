using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservingButton : MonoBehaviour
{
    bool check = true;
    GameObject obj;
    public void SetGameObject()
    {
        check = !check;
        obj.SetActive(check);
    }
    void Start()
    {
        obj = GameObject.Find("Cube");
        ObserverManager.Instance.ObservClickEvent(SetGameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
