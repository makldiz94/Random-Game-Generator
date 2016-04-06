using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigateWin : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }

        if (Input.GetKeyDown("1"))
        {
            Debug.Log("Play Again");
            SceneManager.LoadScene("Michael New");
        }
    }
}
