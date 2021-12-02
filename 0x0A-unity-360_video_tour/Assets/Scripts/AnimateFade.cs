using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateFade : MonoBehaviour
{
    // onclick event plays fade in/out

    public GameObject Fadein;
    public GameObject Fadeout;
    public GameObject FadeCanvas;

    public void FadetoBlack()
    {
        Debug.Log("FadeInOut Called");
        FadeCanvas.SetActive(true);
        Fadein.GetComponent<Animation>().Play("toBlack");
        new WaitForSeconds(1);
       // yield return new WaitForSeconds(1);
       // FadeCanvas.SetActive(false);
        
    }

    public void FadetoScene()
    {
        Fadeout.GetComponent<Animation>().Play("toScene");
        new WaitForSeconds(1);
        FadeCanvas.SetActive(false);
        Debug.Log("All Steps called");
    }
}
