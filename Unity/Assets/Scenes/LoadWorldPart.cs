using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWorldPart : MonoBehaviour
{

    public string m_sceneToLoad;

    private bool m_loaded;

    private void OnTriggerEnter(Collider other)
    {
        if (m_loaded) return;

        m_loaded = true;

        StartCoroutine(LoadScene());
     }

    private IEnumerator LoadScene()
    {
        AsyncOperation loadScene
            = SceneManager.LoadSceneAsync(m_sceneToLoad, LoadSceneMode.Additive);
        loadScene.allowSceneActivation = true;

        yield return loadScene;
        Debug.Log("Scene was loaded");
    }

}
