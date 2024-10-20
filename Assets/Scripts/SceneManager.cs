using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject mainMenuPanel;
    public GameObject instructionsPanel;   

    public Button instructionsButton;      
    public Button backButton;              
    public Button startGameButton;         
    public Button quitButton;              

    void Start()
    {
       
        mainMenuPanel.SetActive(true);
        instructionsPanel.SetActive(false);

       
        instructionsButton.onClick.AddListener(OpenInstructions);
        backButton.onClick.AddListener(BackToMainMenu);
        startGameButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    
    void OpenInstructions()
    {
        mainMenuPanel.SetActive(false);      
        instructionsPanel.SetActive(true);   
    }

    void BackToMainMenu()
    {
        instructionsPanel.SetActive(false);  
        mainMenuPanel.SetActive(true);       
    }

    
    void StartGame()
    {
        Debug.Log("Start Game button clicked");
        mainCanvas.SetActive(false);
    }

    
    void QuitGame()
    {
        Application.Quit();  
    }
}
