using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin_Menu: MonoBehaviour
{
    private AudioSource click;

    private void Start()
    {
        click = gameObject.GetComponent<AudioSource>();
    }
    public void LoatTo(int level)
    {
       // Debug.Log("aga");
        if (!click.isPlaying)
            click.Play();
        SceneManager.LoadScene(level);
    }

    public void AppQuick()
    {
        if (!click.isPlaying)
        {
            click.Play();
        }
        Debug.Log("Quit");
        Application.Quit();
    }
}
