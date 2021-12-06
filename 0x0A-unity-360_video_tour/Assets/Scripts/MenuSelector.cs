using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MenuSelector : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Living;
    public GameObject Cantina;
    public GameObject Mezz;

    public Animator fader;

    void Start()
    {

    }

    void Update() 
    {

    }
    
    // on click event will deactivate all but Living UI Canvas

   public void LivingRoomMenu()
   {
     
       StartCoroutine(LivingWait());
       Debug.Log("back in calling function");
       
   }


    // on click event will deactivate all but Cube UI Canvas
   public void CubeMenu()
   {
       
       StartCoroutine(CubeWait());
       Debug.Log("back in calling function");
       
       
   }

    // on click event will deactivate all but Mezz UI Canvas
   public void MezzMenu()
   {
       
       StartCoroutine(MezzWait());
       Debug.Log("back in calling function");
    
       
   }

    // on click event will deactivate all but Mezz UI Canvas
   public void CantinaMenu()
   {
       
       StartCoroutine(CantWait());
       Debug.Log("back in calling function");
      
       
   }

   IEnumerator CubeWait()
   {
       fader.SetBool("FadeOut", true);
       Debug.Log("BLACKOUT");
       yield return new WaitForSeconds(2);
       Debug.Log("waited two seconds");
       Living.SetActive(false);
       Cantina.SetActive(false);
       Mezz.SetActive(false);
       Cube.SetActive(true);
       fader.SetBool("FadeOut", false);
   }

 IEnumerator MezzWait()
   {
       fader.SetBool("FadeOut", true);
       Debug.Log("BLACKOUT");
       yield return new WaitForSeconds(2);
       Debug.Log("waited two seconds");
       Living.SetActive(false);
       Cantina.SetActive(false);
       Mezz.SetActive(true);
       Cube.SetActive(false);
       fader.SetBool("FadeOut", false);
   }

    IEnumerator LivingWait()
   {
       fader.SetBool("FadeOut", true);
       Debug.Log("BLACKOUT");
       yield return new WaitForSeconds(2);
       Debug.Log("waited two seconds");
       Living.SetActive(true);
       Cantina.SetActive(false);
       Mezz.SetActive(false);
       Cube.SetActive(false);
       fader.SetBool("FadeOut", false);
   }

    IEnumerator CantWait()
   {
       fader.SetBool("FadeOut", true);
       Debug.Log("BLACKOUT");
       yield return new WaitForSeconds(2);
       Debug.Log("waited two seconds");
       Living.SetActive(false);
       Cantina.SetActive(true);
       Mezz.SetActive(false);
       Cube.SetActive(false);
       fader.SetBool("FadeOut", false);
   }
}
