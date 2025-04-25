using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    [SerializeField] private bool showDebug = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Trigger Entered!");
    }
    private void OnTriggerStay2D(Collider2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Trigger Stayy!");
    }
    private void OnTriggerExit2D(Collider2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Trigger Exit!");
    }
}
