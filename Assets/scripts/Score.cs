using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Transform player;

    public Text score;

    void FixedUpdate()
    {
        score.text = player.position.z.ToString("0");
    }
}
