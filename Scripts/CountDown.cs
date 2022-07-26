using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public GameObject reward;
    public GameObject rewardFake;
    [SerializeField] Text timertext;
    [SerializeField] float duration, currentTime;

    public GameObject gameOverPanel;
    void Start()
    {
        currentTime = duration;
        timertext.text = currentTime.ToString();
        StartCoroutine(timeIEn());
    }

    IEnumerator timeIEn()
    {
        while(currentTime >= 0)
        {
            timertext.text = "TIME LEFT: " + currentTime;
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        OpenScene();
    }

    void OpenScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        timertext.text = "";
    }
}
