﻿using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    Animator anim;
    float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Zombie.gotYou)
        {
            Zombie.zombieKilled = 0;
            Zombie.gotYou = false;
            Zombie.lastBossKilled = 0;

            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            if (restartTimer >= 5)
            {             
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
