using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject targetObject = null;
    private GameObject[] targetObjects = null;
    public bool isActive = false;

    public Button targetObjectPanel;
    public Transform content;

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
        InitContent();
    }

    private void InitContent()
    {
        targetObjects = Resources.LoadAll<GameObject>("TargetObjectPrefabs");
        foreach (GameObject item in targetObjects)
        {
            GameObject target = Instantiate(item, GameObject.Find("Target").transform);
            target.SetActive(false);

            Button button = Instantiate(targetObjectPanel, content).GetComponent<Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = target.name.Replace("(Clone)", string.Empty);

            button.onClick.AddListener(() =>
            {
                for(int index = 0; index < GameObject.Find("Target").transform.childCount; index++)
                {
                    GameObject.Find("Target").transform.GetChild(index).gameObject.SetActive(false);
                }
                target.SetActive(true);
                target.transform.localRotation = Quaternion.identity;
                targetObject = target;
                isActive = true;
            });
        }
    }
}
