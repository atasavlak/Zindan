using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gamemanager { get; private set; }
    public UnitHealth _playerHealth = new UnitHealth(100, 100);
    public UnitHealth _enemySkeletonHealth = new UnitHealth(20, 20);
    public UnitHealth _enemyWizardHealth = new UnitHealth(10, 10);

    public GameObject gameOverScreen; 
    public HealthBar healthBar; 

    void Awake()
    {
        if (gamemanager != null && gamemanager != this)
        {
            Destroy(gameObject); 
            return;
        }
        

        gamemanager = this;
        
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Escape)) //Get the Esc / Escape key via the keycode enum
            Application.Quit(); //Quit the game lol
        if (_playerHealth.Health <= 0)
        {
            ShowGameOverScreen();
        }

        healthBar.SetHealth(_playerHealth.Health, _playerHealth.MaxHealth);
    }

    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); 
        Time.timeScale = 0; 
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
        ResetPlayerHealth(); 
    }

    private void ResetPlayerHealth()
    {
        _playerHealth = new UnitHealth(100, 100); 
    }
}
