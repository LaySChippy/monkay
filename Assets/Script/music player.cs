using UnityEngine;

public class musicplayer : MonoBehaviour
{
    private AudioSource bgMusic;

    void Start(){
        bgMusic = GetComponent<AudioSource>();
        bgMusic.Play();
    }
}
   