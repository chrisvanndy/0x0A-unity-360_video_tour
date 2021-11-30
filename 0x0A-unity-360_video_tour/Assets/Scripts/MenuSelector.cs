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

    void Start()
    {
    
    }

    // on click event will deactivate all but Living UI Canvas
   public void LivingRoomMenu()
   {
       Cube.SetActive(false);
       Cantina.SetActive(false);
       Mezz.SetActive(false);
       Living.SetActive(true);
   }


    // on click event will deactivate all but Cube UI Canvas
   public void CubeMenu()
   {
       Living.SetActive(false);
       Cantina.SetActive(false);
       Mezz.SetActive(false);
       Cube.SetActive(true);

   }

    // on click event will deactivate all but Mezz UI Canvas
   public void MezzMenu()
   {
       Cube.SetActive(false);
       Living.SetActive(false);
       Cantina.SetActive(false);
       Mezz.SetActive(true);

   }

    // on click event will deactivate all but Mezz UI Canvas
   public void CantinaMenu()
   {
       Cube.SetActive(false);
       Living.SetActive(false);
       Mezz.SetActive(false);
       Cantina.SetActive(true);
   }

}
