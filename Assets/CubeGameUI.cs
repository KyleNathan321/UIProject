using UnityEngine;
using UnityEngine.UIElements;

public class CubeGameUI : MonoBehaviour
{
    public CubeGameUI cube;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonStart = root.Q<Button>("ButtonStart");
        Button buttonStop = root.Q<Button>("ButtonStop");
        Button buttonRestart = root.Q<Button>("ButtonRestart");

       
    }
}
