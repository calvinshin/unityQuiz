using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestionUI : MonoBehaviour
{
    [SerializeField]
    public GameObject answerButton;
    [SerializeField]
    public Transform answerPanel;


    public virtual void UpdateQuestionInfo(Question question)
    {
        // base class that every other ui will use
        // want to do random, so do a switch. This orders randomly theoretically.
        // orderby is a O(n log n) whereas fisher-yates is an O(n) shuffle.
        question.answerChoices = question.answerChoices.OrderBy(answer => Random.value).ToArray();

        // Create a button for each of these answer choices
        foreach(string answer in question.answerChoices)
        {
            // need an answerbutton class to replace this Transform
            Transform answerButtonInstance = Instantiate(answerButton, answerPanel).transform;
            
            // Then populate text with the answer data
        }
    }

}
