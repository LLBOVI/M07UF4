using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : MonoBehaviour
{
    public SentimentSO sentiment;
    public static event Action<int> SetEmotion = delegate{};
    public void SetEmotions()
    {
        SetEmotion.Invoke(sentiment.num);
    }
}
