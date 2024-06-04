using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class clock : MonoBehaviour
{
    public Image blackScreen;
    public float fadeDuration = 1f;
    public TextMeshPro textMeshPro;
    public float countdownTime = 300f; //temps en segons
    private float currentTime;
    public bool startcd;
    public AudioSource tictac;
    void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshPro>();
        }

        currentTime = countdownTime;
        UpdateText();
        startcd = false;
        blackScreen.color = new Color(0, 0, 0, 0);

    }

    void Update()
    {
        if (startcd == true && currentTime >= 0)
        {
            currentTime -= Time.deltaTime;
            UpdateText();

            if (currentTime <= 0)
            {
                currentTime = 0;
                OnCountdownEnd();
            }
        }
    }

    void UpdateText()
    {
        if (currentTime > 0)
        {
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            textMeshPro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    void OnCountdownEnd()
    {
        FadeToScene("Lose");
    }
    public void StartCd()
    {
        startcd = true;
        tictac.Play();
    }
    public void StopCd()
    {
        startcd = false;
        tictac.Stop();

    }
    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOutIn(sceneName));
    }

    private IEnumerator FadeOutIn(string sceneName)
    {
        // Fade to black
        yield return StartCoroutine(Fade(1f));

        // Cambiar de escena
        SceneManager.LoadScene(sceneName);

        // Fade from black
        yield return StartCoroutine(Fade(0f));
    }

    private IEnumerator Fade(float targetAlpha)
    {
        float startAlpha = blackScreen.color.a;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);
            blackScreen.color = new Color(0, 0, 0, alpha);
            yield return null;
        }

        // Asegurarse de que el Alpha sea exactamente el targetAlpha al final
        blackScreen.color = new Color(0, 0, 0, targetAlpha);
    }

}
