using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstantiateGroups : MonoBehaviour
{
    public GameObject whereToInstantiate, groupPrefab, createGroupObject;
    public List<Group> groups = new List<Group>();

    public Text groupName;

    private void Start()
    {
        float heightOfScrollObject = createGroupObject.GetComponent<RectTransform>().sizeDelta.y + 90;
        foreach(Group g in GetGroups())
        {
            GameObject instantiatedObject = Instantiate(g.prefab, whereToInstantiate.transform);

            heightOfScrollObject += (instantiatedObject.GetComponent<RectTransform>().sizeDelta.y + whereToInstantiate.GetComponent<VerticalLayoutGroup>().spacing);
            whereToInstantiate.GetComponent<RectTransform>().sizeDelta = new Vector2(whereToInstantiate.GetComponent<RectTransform>().sizeDelta.x, heightOfScrollObject);

            createGroupObject.transform.SetAsLastSibling();

        }


        //Check if the player just has created a group?
        if(PlayerPrefs.HasKey("newGroupName") && PlayerPrefs.HasKey("newGroupDesc") && PlayerPrefs.HasKey("newGroupTimer"))
        {
            groups.Add(new Group(PlayerPrefs.GetString("newGroupName"), 3, groupPrefab));


            //Resetting...
            PlayerPrefs.DeleteKey("newGroupName");
            PlayerPrefs.DeleteKey("newGroupDesc");
            PlayerPrefs.DeleteKey("newGroupTimer");
        }
    }

    

    private List<Group> GetGroups()
    {
        List<Group> tempGroups = groups;
        groups.Add(new Group("TestGroup1", 2, groupPrefab));
        groups.Add(new Group("TestGroup2", 3, groupPrefab));
        groups.Add(new Group("TestGroup3", 3, groupPrefab));
        //groups.Add(new Group("TestGroup4", 3, groupPrefab));
        //groups.Add(new Group("TestGroup5", 3, groupPrefab));

        return tempGroups;
    }




    public GameObject exerciseButton;
    public void OnClick( Text text)
    {
        groupName.text = text.text;
        groupName.transform.parent.parent.gameObject.SetActive(true);
        exerciseButton.SetActive(true);
        print("test");

    }
}


public class Group
{
    public string name;
    public int placement;
    public GameObject prefab;

    public Group(string _name, int _placement, GameObject _prefab)
    {
        name = _name;
        placement = _placement;
        prefab = _prefab;
    }

    public Group()
    {
        name = "";
        placement = 0;
        prefab = null;
    }
}