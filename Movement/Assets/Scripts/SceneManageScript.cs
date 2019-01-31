using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public GameObject exerciseTab,exerciseButton, currentGroupSelected;

    public void SwitchToMainScreen()
    {
        if(exerciseTab != null)
            exerciseTab.SetActive(false);

        if(exerciseButton != null)
            exerciseButton.SetActive(false);

        if(currentGroupSelected != null)
            currentGroupSelected.SetActive(false);

        SceneManager.LoadScene("HomeScreen");
    }

    public void SwitchToCreateGroupScreen()
    {
        SceneManager.LoadScene("CreateGroup");
    }

    public void SwitchToLoginScreen()
    {
        SceneManager.LoadScene("Login");
    }

    public void ToggleExerciseTab()
    {
        exerciseTab.SetActive(!exerciseTab.activeSelf);
    }
}
