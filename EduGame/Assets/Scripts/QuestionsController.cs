using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class QuestionsController : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question1_correct_comment;
    public GameObject question1_wrong_comment;
    public GameObject question2_correct_comment;
    public GameObject question2_wrong_comment;
    
    public GameObject question3_correct_comment;
    public GameObject question3_wrong_comment;
    public bool to_next_question = false;
    public int question_picker = 0;
    public int score = 0;
    public GameObject score_panel;
    public GameObject score0;
    public GameObject score1;
    public GameObject score2;
    public GameObject score3;
    public bool score_is_showing = false;


    // Start is called before the first frame update
    void Start()
    {
        ShowQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& to_next_question==true)
        {
            ShowQuestion();
        }
        if(question_picker==4&& score_is_showing==false)
        {
            question3.SetActive(false);
            showscore();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void ShowQuestion()
    {
        question_picker = question_picker+1;
        to_next_question = false;
        if(question_picker==1)
        {
            question1.SetActive(true);
            question2.SetActive(false);
            question3.SetActive(false);
        }
        if(question_picker==2)
        {
            question1.SetActive(false);
            question2.SetActive(true);
            question3.SetActive(false);
        }
        if(question_picker==3)
        {
            question1.SetActive(false);
            question2.SetActive(false);
            question3.SetActive(true);
        }
    }
    public void question1correctanswer()
    {
        question1_correct_comment.SetActive(true);
        question1_wrong_comment.SetActive(false);
        to_next_question = true;
        score = score+1;
    }
    public void question1wronganswer()
    {
        question1_correct_comment.SetActive(false);
        question1_wrong_comment.SetActive(true);
        to_next_question = true;
    }
    public void question2correctanswer()
    {
        question2_correct_comment.SetActive(true);
        question2_wrong_comment.SetActive(false);
        to_next_question = true;
        score = score+1;
    }
    public void question2wronganswer()
    {
        question2_correct_comment.SetActive(false);
        question2_wrong_comment.SetActive(true);
        to_next_question = true;
    }
    public void question3correctanswer()
    {
        question3_correct_comment.SetActive(true);
        question3_wrong_comment.SetActive(false);
        to_next_question = true;
        score = score+1;
    }
    public void question3wronganswer()
    {
        question3_correct_comment.SetActive(false);
        question3_wrong_comment.SetActive(true);
        to_next_question = true;
    }
    public void showscore()
    {
        score_is_showing = true;
        question_picker = question_picker+1;
        if(score==0)
        {
            score_panel.SetActive(true);
            score0.SetActive(true);
            score1.SetActive(false);
            score2.SetActive(false);
            score3.SetActive(false);
        }
        else if (score ==1)
        {
            score_panel.SetActive(true);
            score0.SetActive(false);
            score1.SetActive(true);  
            score2.SetActive(false);
            score3.SetActive(false);
        }
        else if (score ==2)
        {
            score_panel.SetActive(true);
            score0.SetActive(false);
            score1.SetActive(false);  
            score2.SetActive(true);
            score3.SetActive(false);
        }
        else if (score ==3)
        {
            score_panel.SetActive(true);
            score0.SetActive(false);
            score1.SetActive(false);  
            score2.SetActive(false);
            score3.SetActive(true);
        }
    }
}
