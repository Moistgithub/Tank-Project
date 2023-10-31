using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int villainscore;
    public TextMeshProUGUI villain;
    public TextMeshProUGUI Hank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        villain.text = villainscore.ToString();
        Hank.text = score.ToString();
    }
}
