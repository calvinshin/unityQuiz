using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TextQuestion extends the existing class QuestionUI
public class TextQuestion : QuestionUI
{
    // when assigned in inspector, can assign the questionstring to the textbox.
    [SerializeField]
    private TMPro.TextMeshProUGUI questionStringText;

    public override void UpdateQuestionInfo(Question question)
    {
        questionStringText.text = question.questionText;
        base.UpdateQuestionInfo(question);
    }
}
