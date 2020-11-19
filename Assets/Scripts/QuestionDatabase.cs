using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Link it to an asset menu
// fileName = What the file name is called
// MenuName = button in context menu (When you click Create - as in Panel, Question will now appear!)
// Order = sorted order of the context menu?
[CreateAssetMenu(fileName = "Questions", menuName = "Create Questions", order = 5)]
// This is an example of a Question Database that will be helpful later
// This is a scriptable object from Unity

// If you create a QuestionDatabase and save the variables, it's saved to the object
// This is similar to other created objects like textures/etc.
// Can save this with a json, xml, etc.
public class QuestionDatabase : ScriptableObject
{
    // display a set of question sets to the inspector
    public List<QuestionSet> questionSets;
    public QuestionSet GetQuestionSet(int level)
    {
        foreach (QuestionSet questionSet in questionSets)
        {
            if(questionSet.level == level)
            {
                return questionSet;
            }
        }
        // else statement
        return new QuestionSet();
    }
}

[System.Serializable]
// struct; bit of data, such as list of questions
public struct QuestionSet
{
    public int level; //this is like a set
    public List<Question> questions;
}