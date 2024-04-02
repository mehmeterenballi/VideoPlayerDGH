using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public TMP_InputField inputField;
    public TextMeshProUGUI errorText;

    public void OnValueChanged(string value)
    {
        string path = Path.Combine("C:/Videolar", value + ".mp4");
        if (File.Exists(path))
        {
            errorText.text = "";
            videoPlayer.url = path;
            videoPlayer.Play();
        }
        else
        {
            errorText.text = "Video bulunamadý.";
        }
    }

    private void Start()
    {
        inputField.onValueChanged.AddListener(OnValueChanged);
    }
}
