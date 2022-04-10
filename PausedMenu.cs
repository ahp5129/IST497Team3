using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedMenu : MonoBehaviour
{
    [SerializeField] private GameObject PausedMenuUI;
    [SerializeField] private bool isPaused;

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
           isPaused = !isPaused;
       }
       if (isPaused)
       {
           ActivateMenu();
       }
       else
       {
           DeactivateMenu();
       }
   }
   void ActivateMenu()
   {
       Time.timeScale = 0;
       AudioListener.pause = true;
       PausedMenuUI.SetActive(true);
   }
   public void DeactivateMenu()
   {
       Time.timeScale = 1;
       AudioListener.pause = false;
       PausedMenuUI.SetActive(false);
       isPaused = false;
   }
}
