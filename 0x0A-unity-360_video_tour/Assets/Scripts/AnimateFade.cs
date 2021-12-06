using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateFade : MonoBehaviour
{
    // onclick event plays fade in/out

   public Animator fader;

    public void FadetoBlack()
    {
       fader.SetTrigger("FadeOut");
       FadetoScene();
        
    }

    public void FadetoScene()
    {
      fader.ResetTrigger("FadeOut");
    }
}
