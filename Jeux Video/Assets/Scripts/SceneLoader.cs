using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
