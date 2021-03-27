using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Stopwatch sw = new Stopwatch();
    public CharacterControl cc;
    float pow_H;
    float pow_V;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        sw.Start();
        cc.Charging();
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        sw.Stop();
        UnityEngine.Debug.Log(sw.ElapsedMilliseconds);
        /*
        pow_H = sw.ElapsedMilliseconds * 0.2f;
        pow_V = sw.ElapsedMilliseconds * 0.5f;
        */
        pow_H = 1000 * 0.2f;
        pow_V = 1000 * 0.5f;
        cc.GetPowerInfo(new Vector3(pow_H, pow_V, 0));
        sw.Reset();
    }
}
