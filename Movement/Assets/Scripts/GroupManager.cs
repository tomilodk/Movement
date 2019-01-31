using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupManager : MonoBehaviour
{
    public GameObject whereToInstantiate, playerPrefab, invitePlayerObject;
    public List<Player> players = new List<Player>();

    private void Start()
    {
        float heightOfScrollObject = invitePlayerObject.GetComponent<RectTransform>().sizeDelta.y + 60;
        foreach (Player p in GetPlayers())
        {
            GameObject instantiatedObject = Instantiate(p.prefab, whereToInstantiate.transform);

            heightOfScrollObject += (instantiatedObject.GetComponent<RectTransform>().sizeDelta.y + whereToInstantiate.GetComponent<VerticalLayoutGroup>().spacing);
            whereToInstantiate.GetComponent<RectTransform>().sizeDelta = new Vector2(whereToInstantiate.GetComponent<RectTransform>().sizeDelta.x, heightOfScrollObject);

            invitePlayerObject.transform.SetAsLastSibling();

        }


       
    }

    private List<Player> GetPlayers()
    {
        List<Player> tempPlayers = players;
        //groups.Add(new Player("TestPlayer4", 3, groupPrefab));
        //groups.Add(new Player("TestPlayer5", 3, groupPrefab));

        return tempPlayers;
    }
}

public class Player
{
    public string name;
    public int score;
    public GameObject prefab;

    public Player(string _name, int _score, GameObject _prefab)
    {
        name = _name;
        score = _score;
        prefab = _prefab;
    }

    public Player()
    {
        name = "";
        score = 0;
        prefab = null;
    }
}