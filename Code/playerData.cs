using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : MonoBehaviour
{
    public int level = 1;

    public void savePlayer()
    {
        SaveSystem.savePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerGetData data = SaveSystem.loadPlayer();

        level = data.level;

        Vector3 position;

        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }

}