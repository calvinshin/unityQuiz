using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TextQuestion extends the existing class QuestionUI
public class ImageQuestion : QuestionUI
{
    // when assigned in inspector, can assign the questionstring to the textbox.
    [SerializeField]
    private TMPro.TextMeshProUGUI questionStringText;
    [SerializeField]
    private ImageQuestion questionImage;

    public override void UpdateQuestionInfo(Question question)
    {
        questionStringText.text = question.questionText;
        questionImage.sprite = question.questionImage;
        base.UpdateQuestionInfo(question);
    }
}
