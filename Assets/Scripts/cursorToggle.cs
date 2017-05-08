using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
public class cursorToggle : NetworkBehaviour {

    private bool isCursorLocked;
    public GameObject PauseMenu;


   
    void Start()
    {
        
        if(isCursorLocked)
            ToggleCursorState();
       
    }
    void Update()
    {
        
            CheckForInput();
            CheckifCursorShouldBeLocked();
        
        
    }
    void ToggleCursorState()
    {
        isCursorLocked = !isCursorLocked;
    }

    void CheckForInput()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            ToggleCursorState();
            if (!isCursorLocked)
            {
                PauseMenu.SetActive(true);
              
            }
            else
            {
             
                PauseMenu.SetActive(false);
            }
        }
    }

    void CheckifCursorShouldBeLocked()
    {
        if(isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
