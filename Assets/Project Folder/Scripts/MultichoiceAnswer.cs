using UnityEngine;
using UnityEngine.Events;

public class MultichoiceAnswer : MonoBehaviour
{

    public string answerText;
    public TXRButtonTouch button;

    public static UnityEvent<string> OnAnswerSelected = new UnityEvent<string>();

    private void Start()
    {
        Init();
    }

    void Init()
    {
        button = GetComponentInChildren<TXRButtonTouch>(true);
        button.Released.AddListener(() => SelectAnswer(answerText));
        button.TextInit();
    }


    void SelectAnswer(string selectedAnswer)
    {
        OnAnswerSelected.Invoke(selectedAnswer);
    }

    internal void SetText(string answer)
    {
        Init();

        button.SetText(answer);
        answerText = answer;
    }
}