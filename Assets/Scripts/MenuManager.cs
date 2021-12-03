using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager sharedInstance;
    public Canvas menuCanvas;
    public Canvas gameCanvas;
    public Canvas gameOverCanvas;
    // Start is called before the first frame update
    
    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
        }
    }
    
    public void ShowMainMenu()
    {
        menuCanvas.enabled = true;
    }
    public void ShowGame()
    {
        gameCanvas.enabled = true;
    }
    public void ShowGameOver()
    {
        gameOverCanvas.enabled = true;
    }

    public void HideMainMenu()
    {
        menuCanvas.enabled = false;
    }
    public void HideGame()
    {
        gameCanvas.enabled = false;
    }
    public void HideGameOver()
    {
        gameOverCanvas.enabled = false;
    }
   

    public void ExitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
    Application.Quit();
    #endif
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
