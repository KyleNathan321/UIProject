using UnityEngine;

public class SoundFX : MonoBehaviour


{

       public AudioSource audioPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

 void onCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.tag == "Collectible"){
        audioPlayer.Play();
    }
 }
}
