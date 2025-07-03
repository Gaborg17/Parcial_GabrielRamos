using UnityEngine;

public class PARALLAX : MonoBehaviour
{
    
    private float displacementSpeed = 500f;

    public RectTransform paralaxImage;
    public RectTransform paralaxImage2;

    private float imageHeight;

    private void Start()
    {
        imageHeight = paralaxImage.rect.height;
        paralaxImage.anchoredPosition = Vector2.zero;
        paralaxImage2.anchoredPosition = new Vector2(0, imageHeight);
    }

    private void Update()
    {
        paralaxImage.anchoredPosition += Vector2.down * displacementSpeed * Time.deltaTime;
        paralaxImage2.anchoredPosition += Vector2.down * displacementSpeed * Time.deltaTime;

        if (paralaxImage.anchoredPosition.y <= -imageHeight)
        {
            paralaxImage.anchoredPosition = paralaxImage2.anchoredPosition + new Vector2(0, imageHeight);
        }
        if (paralaxImage2.anchoredPosition.y <= -imageHeight)
        {
            paralaxImage2.anchoredPosition = paralaxImage.anchoredPosition + new Vector2(0, imageHeight);
        }

    }
}
