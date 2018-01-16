using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public void PlayGame () {
		SceneManager.LoadScene ("Gameplay");
	}

	public void BackToMenu () {
		SceneManager.LoadScene ("MainMenu");
	}

} // LevelController