using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int scoreCount;
    public Text scoreText;

 void Awake () {
    Instance = this;
 }
 void Update () {
    scoreText.text = "Collectibles Collected:  " + scoreCount.ToString();
 }

 }