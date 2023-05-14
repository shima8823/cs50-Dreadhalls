using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Floor";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Floor " + DontDestroy.instance.dungeonFloor;
    }
}
