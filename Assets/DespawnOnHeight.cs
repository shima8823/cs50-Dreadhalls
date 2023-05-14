using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            // Get audio source from WhisperSource object and stop bgm
            AudioSource bgmSource = GameObject.Find("WhisperSource").GetComponent<AudioSource>();
            bgmSource.Stop();

            DontDestroy.instance.dungeonFloor = 1;
            SceneManager.LoadScene("GameOver");
        }
    }
}
