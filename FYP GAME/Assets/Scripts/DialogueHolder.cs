using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{

    public string dialogue;

    private DialogueManager dMan;
    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Crawler")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                dMan.ShowBox(dialogue);
            }
        }

    }
}
