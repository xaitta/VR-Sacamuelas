using UnityEngine;
using TMPro;

public class clock : MonoBehaviour
{
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
    }

    void Update()
    {
        if (startcd == true && currentTime > 0)
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
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        textMeshPro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnCountdownEnd()
    {
  
        //TODO: S'acaba el timer

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
}