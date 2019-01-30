using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGroup : MonoBehaviour
{
    public InputField iGroupName, iGroupDesc, iGroupDays;
    public SceneManageScript sMS;

    public void CreateButtonPress()
    {
        if(iGroupName.text != "" && iGroupDesc.text != "" && iGroupDays.text != "")
        {
            NewGroup newGroup = new NewGroup(iGroupName.text, iGroupDesc.text, int.Parse(iGroupDays.text));
            PlayerPrefs.SetString("newGroupName", newGroup.groupName);
            PlayerPrefs.SetString("newGroupDesc", newGroup.groupDescription);
            PlayerPrefs.SetInt("newGroupTimer", newGroup.groupDays);
            sMS.SwitchToMainScreen();

        }
        if (iGroupName.text == "")
        {
            iGroupName.placeholder.color = new Color(255, 0, 0);
        }
        if (iGroupDesc.text == "")
        {
            iGroupDesc.placeholder.color = new Color(255, 0, 0);
        }
        if (iGroupDays.text == "")
        {
            iGroupDays.placeholder.color = new Color(255, 0, 0);
        }



    }
}

public class NewGroup
{
    public string groupName;
    public string groupDescription;
    public int groupDays;

    public NewGroup(string gn, string gd, int days)
    {
        groupName = gn;
        groupDescription = gd;
        groupDays = days;
    }

    public NewGroup()
    {
        groupName = "Unnamed";
        groupDescription = "No description";
        groupDays = 0;
    }

}
