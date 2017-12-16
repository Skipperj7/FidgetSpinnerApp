using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour {
	public Button start;
	public Button settings;

	public Button back;
	public GameObject can1;
	public GameObject can2;
	// Use this for initialization
	void Start () {
		start.onClick.AddListener(startSet);
		settings.onClick.AddListener(settingsSet);
		
		back.onClick.AddListener(backSet);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startSet()
	{
		SceneManager.LoadScene(1);
	}
	void settingsSet()
	{
		can1.SetActive(false);
		can2.SetActive(true);
	}



	void backSet()
	{
		can1.SetActive(true);
		can2.SetActive(false);
	}
}
