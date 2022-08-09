using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayforth : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text incText;

    public int inc = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scoreUp()
{
    score += inc;
    scoreText.text = score.ToString();
}

public void shop()
{
    if(score >=5)
    {
        score -= 5;
        inc += 1;
        scoreText.text = score.ToString();
        incText.text = "inc " + inc;
    }

    
}



}
