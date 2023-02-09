using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] List<Pin> pins;
    int score = 0;

    void Start()
    {
        if (instance == null) instance = this;
        else Destroy(this);
    }

    void Update()
    {
        
    }

    public void CheckPins()
    {
        foreach (Pin p in pins)
        {
            if (p.CheckHit()) Debug.Log("Check");
        }
    }
    public void AddScore(Pin p)
    {
        score++;
        Debug.Log(score);
    }
}
