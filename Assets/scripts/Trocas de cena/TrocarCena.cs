using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

}
