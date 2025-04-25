using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[System.Serializable]
public class MainMenuController : MonoBehaviour
{
    //THIS SCRIPT IS ATTACHED TO AN EMPY GAMEOBJECT WITH A UI DOCUMENT COMPONENT
    [SerializeField] private VisualElement _userInterface;
    [SerializeField] private Button _newGameButton;
   // [SerializeField] private Button _continueButton;
    [SerializeField] private Button _CreditsButton;
    [SerializeField] private Button _exitButton;
    private Button _mainMenu;
      private VisualElement _root;
   // [SerializeField] private Label _saveStatus;


    private void Awake()
    {
        _userInterface = GetComponent<UIDocument>().rootVisualElement;
      

    }

    private void OnEnable()
    {
        //  _mainMenu = _root.Q<Button>("MenuButton");
      //  _mainMenu.clicked += MainMenuClicked;
        
        //Look for the UI button called NewGame
        _newGameButton = _userInterface.Q<Button>("StartButton");
        //Check for click on the button and run OnNewGameClicked function below
        _newGameButton.clicked += OnNewGameClicked;

       // _continueButton = _userInterface.Q<Button>("ContinueButton");
       // _continueButton.clicked += OnContinueClicked;
        
       _CreditsButton = _userInterface.Q<Button>("CreditsButton");
        _CreditsButton.clicked += OnCreditsClicked;

      //  _MenuButton = _userInterface.Q<Button>("MenuButton");
        //_MenuButton.clicked += MainMenuClicked;

        _exitButton = _userInterface.Q<Button>("QuitButton");
        _exitButton.clicked += OnExitClicked;
        //_saveStatus = _userInterface.Q<Label>("Status");
    }

    private void OnNewGameClicked()
    {
        //_saveStatus.text = ""; //clear save status text if there was any text
        //PlayerPrefs.DeleteAll();//clear old data/playerprefs
        SceneManager.LoadScene("SampleScene"); //load game level as a new game
    }
       private void MainMenuClicked()
    {
        PlayerPrefs.Save(); //save all preferences before loadng to start screen
        SceneManager.LoadScene("Main Menu"); // load the start screen
    }
    
      private void OnCreditsClicked()
    {
        SceneManager.LoadScene("Credits"); //load game level as a new game
    }
    

  //  private void OnContinueClicked()
    //{
        //check if the plyer has level saved
    //    if (PlayerPrefs.HasKey("playerStarted")) //check if player had previous save data
      //  {
        //    _saveStatus.text = ""; //clear save status text if there was any text
          //  SceneManager.LoadScene("SampleScene");//load game level
       // }
       // else
       // {
        //    _saveStatus.text = "No Save Game Found";
       // }

 //   }

    private void OnExitClicked()
    {
        //_saveStatus.text = "";
        Application.Quit();
    }


}
