using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetObject = null;
    public bool isActive = false;

    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    private void Start()
    {
        FindTargetObject(0);
    }

    public void FindTargetObject(int index)
    {
        targetObject = GameObject.Find("Target").transform.GetChild(index).gameObject;
        if (targetObject != null) isActive = true;
    }
}
