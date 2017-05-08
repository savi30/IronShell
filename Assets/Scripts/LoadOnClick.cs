using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;
	
	public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
        loadingImage.SetActive(true);

    }
	
}
