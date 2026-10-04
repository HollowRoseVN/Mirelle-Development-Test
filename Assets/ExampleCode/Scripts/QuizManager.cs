using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI feedbackTextDisplay;

    public void CheckAnswer(string chosenAnswer)
    {
        if (feedbackTextDisplay == null)
        {
            Debug.LogError("Please assign the FeedbackText object to the QuizManager script component!");
            return;
        }

        switch (chosenAnswer)
        {
            case "A":
                feedbackTextDisplay.text = "You pressed A. Correct!";
                break;

            case "B":
                feedbackTextDisplay.text = "You pressed B. Incorrect. :(";
                break;

            case "C":
                feedbackTextDisplay.text = "You pressed C. Incorrect.";
                break;

            case "D":
                feedbackTextDisplay.text = "You pressed D. Incorrect.";
                break;

            default:
                feedbackTextDisplay.text = "Unknown button pressed.";
                break;
        }
    }
}