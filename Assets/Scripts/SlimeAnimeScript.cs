using UnityEngine;

public class SlimeAnimeScript : MonoBehaviour
{
    public GameObject someObject1;
    public GameObject someObject2;
    int frameCount = 0;
    bool showFlag = true;
    const int FIXED_FRAME_RATE = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = FIXED_FRAME_RATE;
        someObject1.SetActive(showFlag);
        someObject2.SetActive(!showFlag);
    }

    // Update is called once per frame
    void Update()
    {
        if (frameCount++ == FIXED_FRAME_RATE)
        {
            showFlag  = !showFlag;
            someObject1.SetActive(showFlag);
            someObject2.SetActive(!showFlag);
            frameCount = 0;
        }
    }
}
