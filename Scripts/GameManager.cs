using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public GameObject sttiengs;

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;
	public GameObject enemy7;
	public GameObject enemy8;
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void no()
    {
		Application.OpenURL("https://youtu.be/oHg5SJYRHA0");
    }

	public void not()
    {
		Application.OpenURL("https://youtu.be/pdnJdfdRnYw");
    }

	public void aplicquit()
    {
		Application.Quit();
    }

	public void cometoseettinfs()
    {
		sttiengs.SetActive(true);
    }

	public void leavesttings()
    {
		sttiengs.SetActive(false);
	}

    public void Update()
    {
        if(enemy1.active == false   && enemy2.active == false && enemy3.active == false && enemy4.active == false && enemy5.active == false && enemy6.active == false && enemy7.active == false && enemy8.active == false)
        {
			StartGame();
        }
		
    }
}