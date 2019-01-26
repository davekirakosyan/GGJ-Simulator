using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMaker : MonoBehaviour
{
    private int count;
    private int countChords;
    private AudioSource audio;
    private char[] chords= new char[] { 'B', 'E', 'G', 'F', 'E', 'B', 'A', 'F' };
    private char chord;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {

        float transpose = -4;
        float note = -2;
        if (Input.GetKeyDown("a")) { note = 14; chord = 'A'; }
        if (Input.GetKeyDown(KeyCode.B) && count == 0)
        {
            note = 4;
            count = 1;
            chord = 'B';
        }
        else if (Input.GetKeyDown(KeyCode.B) && count == 1)
        {
            note = 16;
            count = 0;
            chord = 'B';
        }

        if (Input.GetKeyDown("e")) { note = 9; chord = 'E'; }
        if (Input.GetKeyDown("f")) { note = 11; chord = 'F'; }
        if (Input.GetKeyDown("g")) { note = 12; chord = 'G'; }

        if (note >= -1)
        {
            audio.pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
            audio.Play();
            Debug.Log(chord);
            Debug.Log(chords[countChords]);
            Debug.Log(countChords);
            if (chord == chords[countChords])
            {
                countChords++;
            }
            else
            {
                countChords = 0; Debug.Log("Wrong");
                count = 0;
            }
            if (countChords == 8) Debug.Log("Win");
            
        }
    }
}
