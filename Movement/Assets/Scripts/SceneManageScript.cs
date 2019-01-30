using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public void SwitchToMainScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void SwitchToCreateGroupScreen()
    {
        SceneManager.LoadScene("CreateGroup");
    }
}
