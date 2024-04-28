using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenTitleScene : MonoBehaviour
{
    public void RealLoadGameScene()
    {
        StartCoroutine("Delay");
    }
    private void LoadGameScene()
    {
        SceneManager.LoadScene("OpeningScene");
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // ���ø����̼� ����
#endif
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        LoadGameScene();
    }
}
