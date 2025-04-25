using UnityEngine;

public class HoleCollider : MonoBehaviour
{
    [SerializeField] private bool showDebug = true;

    private void OnTriggerStay2D(Collider2D objectCollidedWith)
    {
        if (showDebug)
            Debug.Log("Trigger stay!");
    }

    private void OnTriggerExit2D(Collider2D objectCollidedWith)
    {
        if (showDebug)
            Debug.Log("Trigger exit!");
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Rock"))
        {
            Destroy(other.gameObject);
        }
    }
}
