using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float timeValue = 30;
    public TextMeshProUGUI timeText;
    public GameObject gameOver;
    public GameObject player;

    private void Start()
    {
        this.gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {

            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay) {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            CallGameOver();
        }
        else if (timeValue > 0) {
            timeToDisplay += 1;
        }

        float mins = Mathf.FloorToInt(timeToDisplay / 60);
        float sec = Mathf.FloorToInt(timeToDisplay % 60);

        this.timeText.text = string.Format("{0:00} : {1:00}", mins, sec);
    }

    void CallGameOver() {
        this.player.SetActive(false);
        this.gameOver.SetActive(true);
    }
}
