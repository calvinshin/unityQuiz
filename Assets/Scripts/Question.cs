﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public enum QuestionType 
    {
        Text = 0,
        ImageWithCaption = 1,
        Audio = 2
    }
    public QuestionType questionType;
    public string questionText;

    // For images
    public Sprite questionImage;
    // For audio
    public AudioClip questionAudio;

    public string correctAnswerKey;
    public string[] answerChoices;


}
