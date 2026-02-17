using UnityEngine;

public class Platemove : MonoBehaviour
{
    public Vector3 startPOS;
    public Vector3 endPOS;
    public Vector3 moveOffset = new Vector3(0f, 0f, 0f); 


    public float lerpSpeed = 2.0f; //in 2 seconds go from pos 1 to pos 2
    float lerpDir = 1.0f;
    float lerpTime = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPOS = transform.position;
        endPOS = startPOS + moveOffset;
        
    }

    // Update is called once per frame
    void Update()
    {
        lerpTime += Time.deltaTime * lerpSpeed * lerpDir;

        if (lerpTime >= 1 && lerpDir > 0)
        {
            lerpDir = -1;
        }
        else if (lerpTime <= 0 && lerpDir < 0)
        {
            lerpDir = 1;
        }

        transform.position = Vector3.Lerp(startPOS, endPOS, lerpTime);

        
    }
}
