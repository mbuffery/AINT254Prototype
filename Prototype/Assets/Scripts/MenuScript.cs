using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public Canvas MainCanvas;
    public Canvas ControlsCanvas;
    public Canvas HowToPlayCanvas;
    
   

    void Awake()
    {
        
        ControlsCanvas.enabled = false;
        HowToPlayCanvas.enabled = false;
        
        
    }
    public void ReturnOn()
    {
        
        MainCanvas.enabled = true;
        ControlsCanvas.enabled = false;
        HowToPlayCanvas.enabled = false;
        
        
    }
    public void ControlsOn()
    {
        
        MainCanvas.enabled = false;
        ControlsCanvas.enabled = true;
        HowToPlayCanvas.enabled = false;
        
        
    }
    public void HelpOn()
    {
       
        MainCanvas.enabled = false;
        ControlsCanvas.enabled = false;
        HowToPlayCanvas.enabled = true;
        
        
    }
    
    public void LoadOn()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
