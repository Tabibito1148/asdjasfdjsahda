using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Obtén el índice de la escena actual
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Carga la escena actual para reiniciarla
        SceneManager.LoadScene(currentSceneIndex);
    }
}
