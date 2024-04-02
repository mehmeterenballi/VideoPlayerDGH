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
        VideoClip clip = Resources.Load<VideoClip>(value);
        if (clip != null)
        {
            errorText.text = "";
            videoPlayer.clip = clip;
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
