using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum KeyboardKeyType { Character, Backspace, Done }
public class KeyboardKey : MonoBehaviour
{

    [SerializeField] KeyboardKeyType type;
    string character;
    TXRButtonTouch btn;
    TXRKeyboard keyboard;
    private void Awake()
    {
        btn = GetComponent<TXRButtonTouch>();
        btn.Pressed.AddListener(OnKeyPressed);
        btn.PressTransform += OnCharacterPressed;
        if (type == KeyboardKeyType.Character)
            character = GetComponentInChildren<TextMeshPro>().text;

        keyboard = GetComponentInParent<TXRKeyboard>();
    }

    private void OnCharacterPressed(Transform toucher)
    {
        keyboard.CharPressed(character,toucher);
    }

    private void OnKeyPressed()
    {
        switch (type)
        {
            case KeyboardKeyType.Backspace:
                keyboard.DeleteLast(); break;
            case KeyboardKeyType.Done:
                keyboard.DonePressed(); break;
            default: break;

        }
    }
}