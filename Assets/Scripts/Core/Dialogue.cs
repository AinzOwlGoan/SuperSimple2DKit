using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script stores every dialogue conversation in a public Dictionary.*/

public class Dialogue : MonoBehaviour
{

    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //Door
        dialogue.Add("LockedDoorA", new string[] {
            "A large door...",
            "Looks like it has a key hole!"
        });


        dialogue.Add("LockedDoorB", new string[] {
            "Key used!"
        });

        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Ciao Elliot!",
            "Davvero non ricordi chi sono?...",
            "E va bene.. se mi procurerai 20 monete ti forniro' piu' info.."
        });

        dialogue.Add("CharacterAChoice1", new string[] {
            "Ciao",
            "",
            ""
        });

        dialogue.Add("CharacterAChoice2", new string[] {
            "Scusa ma chi sei?",
            "...",
            ""
        });

        dialogue.Add("CharacterB", new string[] {
            "Sono io депрессия!",
            "Il tuo caro amico...",
            "Quello che ti sta accompagnando da tanto tempo, più avanzi e più ricorderai..."
        });
    }
}
