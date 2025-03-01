using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuEvents : MonoBehaviour
{
 private UIDocument _document;

 private Button _button;

 private void Awake()
 
 {
    _document = GetComponent<UIDocument>();

    _button = _document.rootVisualElement.Q("StartButton") as Button;
    _button.RegisterCallback<ClickEvent>(OnPlayGameClick);

 }


 private void OnDisable()
{
    
}

 private void OnPlayGameClick(ClickEvent evt)
 {
    Debug.Log("You Pressed the Start Button");
 }


}
