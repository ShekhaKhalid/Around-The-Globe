using UnityEngine;
using UnityEngine.SceneManagement;

public class WatchUI : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject FossilCnves;
    public GameObject InstructionsCnves;

    void Start()
    {
        MenuCanvas.SetActive(false);
        FossilCnves.SetActive(false);
        InstructionsCnves.SetActive(false);
    }

    public void OpenMenu()
    {
        MenuCanvas.SetActive(!MenuCanvas.activeSelf);
    }

    public void CloseMenu()
    {
        MenuCanvas.SetActive(false);
    }

    public void OpenFossil()
    {
        FossilCnves.SetActive(!FossilCnves.activeSelf);
    }

    public void CloseFossil()
    {
        FossilCnves.SetActive(false);
    }

    public void OpenInstructions()
    {
        InstructionsCnves.SetActive(!InstructionsCnves.activeSelf);
    }

    public void CloseInstructions()
    {
        InstructionsCnves.SetActive(false);
    }

    public void ChangeToGalleryScene()
    {
        SceneManager.LoadScene("newGallery");
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void CloseEverything()
    {
        MenuCanvas.SetActive(false);
        InstructionsCnves.SetActive(false);
        FossilCnves.SetActive (false);
    }
}
