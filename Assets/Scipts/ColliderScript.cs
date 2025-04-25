using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] private bool showDebug = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Collision has entered!");
    }
    private void OnCollisionStay2D(Collision2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Collision stay!");
    }
    private void OnCollisionExit2D(Collision2D objectCollideWidth)
    {
        if (showDebug)
        Debug.Log("Collision exit!");
    }
    
}
