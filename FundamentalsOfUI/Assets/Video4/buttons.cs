using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    public Text chatText;

    void Awake()
    {
        chatText = chatText.GetComponent<Text>();
    }

    public void PlayButton (int scene)
    {
		SceneManager.LoadScene(scene);
	}

    public void ExitButton ()
	{
		Application.Quit ();
	}

    public void ToggleButton(bool mainMenu)
    {
        if (mainMenu)
            SceneManager.LoadScene("Video5Scene");
    }

    public void ChatInput(InputField chat)
    {
        chatText.text = chat.text;
    }
}
