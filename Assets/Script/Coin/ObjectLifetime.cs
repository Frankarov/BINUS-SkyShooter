using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class ObjectLifetime : MonoBehaviour
{

    public float LifeTime;
    public float blinkingDelay;
    public UnityEvent onTimerReachedZero;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = LifeTime;
        StartCoroutine(ObjectTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=0)
        {
            onTimerReachedZero.Invoke();
        }

        timer -= Time.deltaTime;
    }

    private IEnumerator ObjectTimer()
    {
        Color defaultColor = GetComponent<SpriteRenderer>().color;
        Color blinkColor = defaultColor;
        blinkColor.a = 0.5f;

        yield return new WaitForSeconds(LifeTime * 0.7f);

        while (timer > 0)
        {
            GetComponent<SpriteRenderer>().color = blinkColor;
            yield return new WaitForSeconds(blinkingDelay);
            GetComponent<SpriteRenderer>().color = defaultColor;
            yield return new WaitForSeconds(blinkingDelay);
        }
    }
}
