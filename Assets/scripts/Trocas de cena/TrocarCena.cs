using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    
    public void MudarCena()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Configuracao()
    {
        SceneManager.LoadScene("Config");
    }

    public void ConfigSom()
    {
        SceneManager.LoadScene("Sons");
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
