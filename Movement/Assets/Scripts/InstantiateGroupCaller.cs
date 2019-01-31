using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateGroupCaller : MonoBehaviour
{
    private GameObject groupsObject;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClickQuery);
    }
    public void OnClickQuery()
    {
        if (GameObject.Find("Groups") != null)
        {
            groupsObject = GameObject.Find("Groups");
            groupsObject.GetComponent<InstantiateGroups>().OnClick(transform.GetChild(0).GetComponent<Text>());
        }
    }

}
