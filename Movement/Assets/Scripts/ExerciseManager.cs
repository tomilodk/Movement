using UnityEngine;
using UnityEngine.UI;

public class ExerciseManager : MonoBehaviour
{
    public Color buttonColor;
    public Button cycle, run, exerciseButton, exitButton;
    public GameObject exerciseWindow;

    private void Start()
    {
        cycle.onClick.AddListener(CycleClick);
        run.onClick.AddListener(RunClick);
        exerciseButton.onClick.AddListener(OnExerciseClick);
        exitButton.onClick.AddListener(ExitMenu);
    }

    private void CycleClick()
    {
        exerciseButton.gameObject.GetComponent<Image>().color = buttonColor;
        ExitMenu();
    }

    private void RunClick()
    {
        exerciseButton.gameObject.GetComponent<Image>().color = buttonColor;
        ExitMenu();
    }

    private void OnExerciseClick()
    {
        if(exerciseButton.gameObject.GetComponent<Image>().color == buttonColor)
        {
            //Stop timer.
            exerciseButton.gameObject.GetComponent<Image>().color = Color.white;
            exerciseWindow.SetActive(true);
        }
    }

    private void ExitMenu ()
    {
        exerciseWindow.SetActive(false);
    }

}
