using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    //private Tween activeTween;
    public List<Tween> activeTweens;
    // Start is called before the first frame update
    void Start()
    {
        activeTweens = new List<Tween>();
    }

    // Update is called once per frame
    void Update()
    {
        List<Tween> finishedTweens = new List<Tween>();
        foreach (Tween tween in activeTweens)
        {

            if (Vector3.Distance(tween.Target.position, tween.EndPos) > 0.1f)
            {
                float timeFraction = (Time.time - tween.StartTime) / tween.Duration;
                timeFraction = Mathf.Pow(timeFraction, 3);
                Vector3.Lerp(tween.StartPos, tween.EndPos, timeFraction);
            }
            else
            {
                tween.Target.position = tween.EndPos;
                finishedTweens.Add(tween);
            }
        }

        foreach (Tween tween in finishedTweens)
        {
            activeTweens.Remove(tween);
        }

    }
    public Boolean TweenExists(Transform target)
    {
        foreach (Tween tween in activeTweens)
        {
            if (tween.Target == target)
            {
                return true;
            }
        }
        return false;
    }
    public bool addTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (TweenExists(targetObject) == false)
        {
            Tween newTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
            activeTweens.Add(newTween);
            return true;
        }
        else
            return false;
    }
}


