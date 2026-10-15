using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TestingScript : MonoBehaviour
{
    int score = 5;
    void Awake()
    {
        score = 0;
        Debug.Log(score);
    }

    void Start()
    {
        score = 10; 
        Debug.Log(score);

    
    }
}
