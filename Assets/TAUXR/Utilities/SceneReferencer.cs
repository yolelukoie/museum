using System.Collections.Generic;
using UnityEngine;


// Stores references for everything needer to refer to in the scene.
public class SceneReferencer : TXRSingleton<SceneReferencer>
{
    //[Header("Configurations")]

    public int NumberOfQuestionsInSemiActiveTour = 3;

    [Header("Art Pieces")]
    public List<Piece> pieces;
    [Header("Active Tour Questions")]
    public List<SerializedMultichoiceQuestion> questions;
    [Header("Beginning Instructions")]
    [TextArea(3, 10)]
    public List<string> instructions;
    [TextArea(3, 10)]
    public List<string> endInstructions;

    [Space(20)]
    [Header("Game Objects")]
    public FloatingBoard floatingBoard;
    public MultiChoiceQuestion multiChoiceQuestion;

}
