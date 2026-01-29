using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public int nextSceneIndex = 1; // scene gameplay

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Skip
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
