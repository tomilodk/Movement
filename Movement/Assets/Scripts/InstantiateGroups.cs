using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateGroups : MonoBehaviour
{
    public GameObject whereToInstantiate, groupPrefab, createGroupObject;

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
    }

    private List<Group> GetGroups()
    {
        List<Group> groups = new List<Group>();

        groups.Add(new Group("TestGroup", 3, groupPrefab));
        groups.Add(new Group("TestGroup2", 3, groupPrefab));
        groups.Add(new Group("TestGroup3", 3, groupPrefab));
        groups.Add(new Group("TestGroup4", 3, groupPrefab));
        groups.Add(new Group("TestGroup5", 3, groupPrefab));

        return groups;
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