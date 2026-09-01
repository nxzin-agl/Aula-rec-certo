using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    
    public void MudarCena()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
