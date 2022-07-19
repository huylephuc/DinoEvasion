using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Level01":
                SceneManager.LoadScene("Project1");
                break;
            case "Level02":
                SceneManager.LoadScene("Project2");
                break;
        }
    }
}
