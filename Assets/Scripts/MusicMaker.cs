using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicMaker : MonoBehaviour
{
    private int count;
    private int countChords;
    private AudioSource audio;
    private char[] chords= new char[] { 'B', 'E', 'G', 'F', 'E', 'B', 'A', 'F' };
    public GameObject[] keys = new GameObject[6];
    private char chord;
    public Text[] noteTexts = new Text[8];
    private Color checkedNoteColor = new Color(255f, 0f, 0f);
    private Color uncheckedNoteColor = new Color(254f, 152f, 203f);
    public Sprite whitePressed;
    public Sprite blackPressed;
    public Sprite whiteUnPressed;
    public Sprite blackUnPressed;

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
            keys[0].GetComponent<RawImage>().texture = whitePressed.texture;
        }
        else if (Input.GetKeyDown(KeyCode.B) && count == 1)
        {
            note = 16;
            count = 0;
            chord = 'B';
            keys[5].GetComponent<RawImage>().texture = whitePressed.texture;
        }
        

        if (Input.GetKeyDown("e")) { note = 9; chord = 'E'; keys[1].GetComponent<RawImage>().texture = whitePressed.texture; }
        if (Input.GetKeyDown("f")) { note = 11; chord = 'F'; keys[3].GetComponent<RawImage>().texture = blackPressed.texture; }
        if (Input.GetKeyDown("g")) { note = 12; chord = 'G'; keys[2].GetComponent<RawImage>().texture = whitePressed.texture; }
        if (Input.GetKeyUp(KeyCode.B) && count == 1)
        {
            keys[0].GetComponent<RawImage>().texture = whiteUnPressed.texture;
        }
        if (Input.GetKeyUp(KeyCode.B) && count == 0)
        {
            keys[5].GetComponent<RawImage>().texture = whiteUnPressed.texture;
        }
        if (Input.GetKeyUp("e")) { keys[1].GetComponent<RawImage>().texture = whiteUnPressed.texture; }
        if (Input.GetKeyUp("f")) { keys[3].GetComponent<RawImage>().texture = blackUnPressed.texture; }
        if (Input.GetKeyUp("g")) { keys[2].GetComponent<RawImage>().texture = whiteUnPressed.texture; }
        if (note >= -1)
        {
            audio.pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
            audio.Play();
            Debug.Log(chord);
            Debug.Log(chords[countChords]);
            Debug.Log(countChords);
            if (chord == chords[countChords])
            {
                noteTexts[countChords].color = checkedNoteColor;
                countChords++;
            }
            else
            {
                for (int i = 0; i <= countChords; i++)
                {
                    noteTexts[i].color = uncheckedNoteColor;
                }
                countChords = 0; Debug.Log("Wrong");
                count = 0;
            }
            if (countChords == 8) Debug.Log("Win");
            
        }
    }
}
