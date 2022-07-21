using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Battle");
        
        //SceneManager.LoadScene("Battle", LoadSceneMode.Single);
        SceneManager.LoadScene("Scenes/Battle", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
