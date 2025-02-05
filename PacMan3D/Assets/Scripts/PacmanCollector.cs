using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanCollector : MonoBehaviour
{
    private int score = 0;
    void Start()
    {
        UpdateScoreText();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SmallPellet"))
        {
            score += 100;
            Destroy(other.gameObject);
            UpdateScoreText();
        }
        else if (other.CompareTag("BigPellet"))
        {
            score += 500;
            Destroy(other.gameObject);
            UpdateScoreText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
