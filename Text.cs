using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public Rigidbody player;
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "velocity.x = " + (Mathf.Round(player.velocity.x*100)/100).ToString() + ", velocity.z = " + (Mathf.Round(player.velocity.z*100)/100).ToString() + ", Cos(rot) = " + (Mathf.Round(Mathf.Cos(player.gameObject.transform.eulerAngles.y*Mathf.Deg2Rad)*100)/100).ToString() + ", Sin(rot) = " + (Mathf.Round(Mathf.Sin(player.gameObject.transform.eulerAngles.y*Mathf.Deg2Rad)*100)/100).ToString() + ", rot° = " + (Mathf.Round(player.gameObject.transform.eulerAngles.y*100)/100).ToString();
    }
}
