using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuCrontroller : MonoBehaviour
{
    private UIDocument document;
    private Button botaoJogar;
    // Start is called before the first frame update
    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaoJogar = document.rootVisualElement.Q<Button>("btnJogar");
        botaoJogar.RegisterCallback<ClickEvent>(OnPlayGame);
    }

    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
}
