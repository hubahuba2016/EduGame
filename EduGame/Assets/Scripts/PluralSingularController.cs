using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PluralSingularController : MonoBehaviour
{
    public GameObject pluralcomment;
    public GameObject singularcomment;
    public int game_controller;
    public bool game_is_plural;
    public bool game_is_singular;
    // Start is called before the first frame update
    void Start()
    {
        game_controller = Random.Range(0,2);
        if(game_controller==0)
        {
            pluralcomment.SetActive(true);
            singularcomment.SetActive(false);
            game_is_plural = true;
            game_is_singular = false;
        }
        if(game_controller==1)
        {
            pluralcomment.SetActive(false);
            singularcomment.SetActive(true);
            game_is_plural=false;
            game_is_singular=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("PluralSingular",LoadSceneMode.Single);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
