using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TourManager : MonoBehaviour
{
    public GameObject[] locations;

    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void ChangeLocation(VideoClip videoclip)
    {
        videoPlayer.clip = videoclip;

    }

    IEnumerator PlayVideoClip(string videoname)
    {
        yield return new WaitForSeconds(2.0f);
        foreach (GameObject room in locations)
        {
            if (room.name == videoname)
            {
                room.SetActive(true);
            }
            else
            {
                room.SetActive(false);
            }
        }

 
    }
}
