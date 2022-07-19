using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform car;
    public Text text;

    void Update()
    {
        text.text = car.position.z.ToString("0");
    }
}
