using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TourManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public Animator fade;


    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void ChangeLocation(VideoClip videoclip)
    {
        StartCoroutine(Wait(videoclip));
        

    }

    IEnumerator Wait(VideoClip videoclip)
    {
        yield return new WaitForSeconds(1);
        videoPlayer.clip = videoclip;
        Debug.Log("waiting in video manager");
        
    }
    public void TourExit()
    {

        Application.Quit();
    }


}


