using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsUIController : MonoBehaviour
{
    public Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(backMainMenu);
    }

    private void backMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
