using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWords : MonoBehaviour
{
    public GameObject[] Words;
    public bool seat_0_is_taken = false;
    public bool seat_1_is_taken = false;
    public bool seat_2_is_taken = false;
    public bool seat_3_is_taken = false;
    public bool seat_4_is_taken = false;
    public bool seat_5_is_taken = false;
    public bool seat_6_is_taken = false;
    public bool seat_7_is_taken = false;
    public bool seat_8_is_taken = false;
    public bool seat_9_is_taken = false;
    public int words_to_spawn = 0;
    public int random_number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(words_to_spawn<10)
        {
            random_number = Random.Range(0,10);
            if(random_number==0 && seat_0_is_taken == false)
            {
                seat_0_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(-5f,2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==1 && seat_1_is_taken == false)
            {
                seat_1_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(0f,2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==2 && seat_2_is_taken == false)
            {
                seat_2_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(5f,2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==3 && seat_3_is_taken == false)
            {
                seat_3_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(-5f,0f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==4 && seat_4_is_taken == false)
            {
                seat_4_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(0f,0f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==5 && seat_5_is_taken == false)
            {
                seat_5_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(5f,0f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==6 && seat_6_is_taken == false)
            {
                seat_6_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(-5f,-2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==7 && seat_7_is_taken == false)
            {
                seat_7_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(0f,-2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==8 && seat_8_is_taken == false)
            {
                seat_8_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(5f,-2f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
            if(random_number==9 && seat_9_is_taken == false)
            {
                seat_9_is_taken = true;
                Instantiate(Words[words_to_spawn], new Vector3(0f,-4f,0f),Quaternion.identity);
                words_to_spawn = words_to_spawn+1;
            }
        }
    }
}
