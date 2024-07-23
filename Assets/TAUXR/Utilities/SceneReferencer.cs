using System.Collections.Generic;
using UnityEngine;


// Stores references for everything needer to refer to in the scene.
public class SceneReferencer : TXRSingleton<SceneReferencer>
{
    //[Header("Configurations")]

    public int NumberOfQuestionsInSemiActiveTour = 3;

    [Header("Art Pieces")]
    public List<Piece> pieces;

    [Header("Demo Pieces")]
    public List<Piece> demoPieces;

    [Header("Demo Instructions")]
    public InstructionsBoard pressToStart;
    public InstructionsBoard welcomeToTheMuseum;
    public InstructionsBoard followTheArrowToTheFirstPiece;
    public InstructionsBoard pressTheButtonToHearAudio;
    public InstructionsBoard answerTheQuestion;
    public InstructionsBoard letsStartTheTour;
    public InstructionsBoard followTheArrow;

    [Header("Active Tour Questions")]
    public List<SerializedMultichoiceQuestion> questions;


    [Header("Instructions")]
    public List<TextAndScaleTuple> ScaledInstructions;

    public List<TextAndScaleTuple> BetweenPiecesMsg;

    public List<TextAndScaleTuple> endInstructionsAndScales;

    //----------------------Game Objects----------------------
    [Space(20)]
    [Header("Game Objects")]
    public FloatingBoard floatingBoard;
    public MultiChoiceQuestion multiChoiceQuestion;
    public MultiChoiceQuestion typeQuestion;
    public ArrowPointer arrowPointer;
    public Collection artCollection;
    public Collection demoCollection;



}


