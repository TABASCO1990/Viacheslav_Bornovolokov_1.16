using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player player;
    public Transform FinishPlatform;
    public Slider Slider;
    public Text textComplite;

    private float _startY;
    private float _minimumReachedY;
    private void Start()
    {
        _startY = player.transform.position.y;
    }
    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, player.transform.position.y);
        float finishY = FinishPlatform.position.y;

        float t = Mathf.InverseLerp(_startY, finishY + 1f, _minimumReachedY);
        Slider.value = t;
        textComplite.text = "Complete: " + (Mathf.Round(Slider.value * 100)).ToString() + "%";
    }
}

