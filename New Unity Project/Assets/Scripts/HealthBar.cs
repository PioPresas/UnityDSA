using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{


    public float barDisplay = 100;
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60, 20);
    public Texture2D progressBarEmpty;
    public Texture2D progressBarFull;

    private void OnGUI()
    {
        Debug.Log("BAR: " + barDisplay);

        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(20, 20, 50, 50), progressBarEmpty);

        //GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        //    GUI.Box(new Rect(0, 0, size.x, size.y), progressBarFull);
        //GUI.EndGroup();

        GUI.EndGroup();
    }

    // Update is called once per frame
    void Update()
    {
        barDisplay -= Time.deltaTime * 10.0f;

        if (barDisplay <= 0)
        {
            barDisplay = 100;
        }


    }
}
