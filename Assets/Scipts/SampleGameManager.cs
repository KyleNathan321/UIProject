using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SampleGameManager : MonoBehaviour
{
    public static SampleGameManager Instance;
    [SerializeField] private int Score = 0;

    private int _totalCoins;
    private Vector3 playerPosition;
    //UI
    private VisualElement _root;
    private Label _scoreLabel;
    private Label _livesLabel;
    private Button _mainMenu;

    private void OnEnable()
    {
        Instance = this; //create a running instance of Sample Game Manager

        //get the UI elements
        _root = GetComponent<UIDocument>().rootVisualElement;
        //query from the root visual element, basically look for the labels
        _scoreLabel = _root.Q<Label>("Score");
        _livesLabel = _root.Q<Label>("Lives");
        _mainMenu = _root.Q<Button>("MenuButton");

        _mainMenu = _root.Q<Button>("MenuButton");
        _mainMenu.clicked += MainMenuClicked;
    }

    private void Start()
    {
        //when game level is loaded, check if there is existing playerprefs
    //  if (!IsNewGame())
      //    LoadGame(); //if it is not a new game, load the existing playerprefs data

        //set up initial UI text on screen
      //_scoreLabel.text = "Score: " + Score.ToString();
      //_totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;

    }
    private void MainMenuClicked()
    {
        PlayerPrefs.Save(); //save all preferences before loadng to start screen
        SceneManager.LoadScene("Main Menu"); // load the start screen
    }

    public void AddScore(int scoreValue)
    {
        Score += scoreValue; // add to total score
        _scoreLabel.text = "Score: " + Score.ToString(); // update the UI
        PlayerPrefs.SetInt("score", Score); //save the data to player prefs
        Debug.Log("SCORE: " + Score.ToString());
    }


    public void GameWin()
    {
        if (Score >= _totalCoins) //check if the score is higher than or equal to the total coins found in the level
        {
            PlayerPrefs.SetString("status", "You Win!"); //set win/lose status to carry over to End Screen
            SceneManager.LoadScene("EndScreen");  // load the end screen
        }
    }

    void LoadGame()
    {
        //get save data
        Score = PlayerPrefs.GetInt("score", 0); //if score does not exist, default to 0
    }

    public bool IsNewGame()
    {
        if (PlayerPrefs.HasKey("playerStarted"))
        {
            return false; //load the game if playerStarted key does not exist
        }
        else
        {
            PlayerPrefs.SetInt("playerStarted", 1); // 1 in this context means TRUE
            return true;
        }
    }

    public Vector3 GetPlayerPosition()
    {
        playerPosition.x = PlayerPrefs.GetFloat("playerPositionX", 0);
        playerPosition.y = PlayerPrefs.GetFloat("playerPositionY", 0);
        playerPosition.z = PlayerPrefs.GetFloat("playerPositionZ", 0);
        return playerPosition;
    }
}
