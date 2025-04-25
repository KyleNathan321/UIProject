using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[System.Serializable]
public class CreditsMenu : MonoBehaviour
{
    //THIS SCRIPT IS ATTACHED TO AN EMPY GAMEOBJECT WITH A UI DOCUMENT COMPONENT
    [SerializeField] private VisualElement _userInterface;
    [SerializeField] private Button _MenuButton;


    private void Awake()
    {
        _userInterface = GetComponent<UIDocument>().rootVisualElement;

    }

    private void OnEnable()
    {
        
        //Look for the UI button called NewGame
        _MenuButton = _userInterface.Q<Button>("MenuButton");
        //Check for click on the button and run OnNewGameClicked function below
        _MenuButton.clicked += MainMenuClicked;

    }

       private void MainMenuClicked()
    {
        PlayerPrefs.Save(); //save all preferences before loadng to start screen
        SceneManager.LoadScene("Main Menu"); // load the start screen
    }

}
