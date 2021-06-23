using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private static Camera instance;
    public GameObject Player;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(gameObject);
    }
    void Start()
    {
        this.transform.position = Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);
        this.transform.position = pos;
    }
}
