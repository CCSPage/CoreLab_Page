using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public string[] sentences;
    public Text dialogueText;
    public float typingSpeed;
    public GameObject continueButton;

    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        dialogueText.text = "";
        StartCoroutine(TextTyper());
        continueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueText.text == sentences[index])
        {
            continueButton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                continueDialogue();
            }
        }
        else
        {
            continueButton.SetActive(false);

        }
    }

    public void continueDialogue()
    {
        index++;
        if (index > sentences.Length - 1)
        {

            index = 0;
        }
        dialogueText.text = "";
        StartCoroutine(TextTyper());
    }

    IEnumerator TextTyper()
    {
        foreach (char c in sentences[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
