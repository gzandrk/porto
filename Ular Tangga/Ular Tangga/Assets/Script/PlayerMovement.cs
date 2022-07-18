﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rute rute;
    public List<Titik> titikList = new List<Titik>();

    int posisiRute;

    int player_id; //apabila ada 2 player, simpen aja buat jaga2
    float speed = 2f;

    int sisaLangkah;
    int langkah;
    public int bonus_Maju;

    bool bolehMaju;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform c in rute.titikList) 
        {
            Titik t = c.GetComponentInChildren<Titik>();
            if(t!=null)
            {
                titikList.Add(t);
            }

        }
    }

    public IEnumerator Maju()
    {
        if (bolehMaju)
        {
            yield break;
        }
        bolehMaju = true;

        //Hapus player
        titikList[posisiRute].RemovePlayer(this);

        while (sisaLangkah > 0) 
        {
            posisiRute++;
            Vector3 nextPos = rute.titikList[posisiRute].transform.position;

            while (PindahTitikSelanjutnya(nextPos))
            {
                yield return null;
            }
            yield return new WaitForSeconds(0.1f);
            sisaLangkah--;
            langkah++;
        }

        //Check harta berisi soal
        if (titikList[posisiRute].bonusMaju == true)
        {
            print("bisa maju");
                    bonus_Maju = Random.Range(1,7);
                    print("bonus maju " + bonus_Maju);
                    while (bonus_Maju > 0)
                    {
                        posisiRute++;
                        Vector3 nextPos = titikList[posisiRute].transform.position;
                        while (PindahTitikSelanjutnya(nextPos))
                        {
                            yield return null;
                        }
                        yield return new WaitForSeconds(0.1f);
                        bonus_Maju--;
                        langkah++;
                    }
        }

        //Hapus player
        titikList[posisiRute].AddPlayer(this);

        //UPDATE GAMEMANAGER
        GameManager.instance.state = GameManager.States.SWITCH_Player;

        bolehMaju = false;
    }

    bool PindahTitikSelanjutnya(Vector3 nextPos)
    {
        return nextPos != (transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime));
    }

    public void Giliran(int angkaDadu) 
    {
        sisaLangkah = angkaDadu;
        if (langkah + sisaLangkah < rute.titikList.Count)
        {
            StartCoroutine(Maju());
        }
        else
        {
            print("Angka terlalu besar: "+angkaDadu);
            //UPDATE GAMEMANAGER
            GameManager.instance.state = GameManager.States.SWITCH_Player;
        }
    }
}
