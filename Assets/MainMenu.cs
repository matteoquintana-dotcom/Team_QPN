using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameUI;

    void Start()
    {
        ShowMainMenuUI();
    }
    public void HideAll()
    {
        mainMenuUI.SetActive(false);
        gameUI.SetActive(false);
    }
    public void ShowGameUI()
    {
        HideAll();
        gameUI.SetActive(true);
    }
}
