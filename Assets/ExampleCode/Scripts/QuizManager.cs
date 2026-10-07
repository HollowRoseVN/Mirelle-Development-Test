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

    public class ButtonBehavior : MonoBehavior
    
    {
        public AButton button:

        private void OnEnable()
        {
        //** Declare events and addevent listeners to inform when button press has occured
            AButton.OnButtonPress.AddListener;
        }

        private void OnDisable()
        {
        //** Remove events and addevent listeners to inform when button press has occured
        //*** We do this to keep from  events being double registered or registring in
        // scripts that the engine has destroyed
            AButton.OnButtonPress.RemoveListener;
        }

        public class BButton:

        private void OnEnable()
        {
        //** Declare events and addevent listeners to inform when button press has occured
            BButton.OnButtonPress.AddListener;
        }

        private void OnDisable()
        {
        //** Remove events and addevent listeners to inform when button press has occured
        //*** We do this to keep from  events being double registered or registring in
        // scripts that the engine has destroyed
            BButton.OnButtonPress.RemoveListener;
        }

        public void BButton()
        {
            DebugLog.(message "Messed up on BButton sis");
        }

        public void AButton()
        {
            DebugLog.(message "Messed up on AButton sis");
        }
    
    }
    
    }
}