using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    public List<PlayerObject> PlayerList = new List<PlayerObject>();
    private GameObject[] player_list;
    private bool player_active = false;
    private int default_player_id=0;
    private int currently_active_index=0;

  //  public List<GameObject> player_list = new List<GameObject>();


    private void Start()
    {
        player_list = new GameObject[PlayerList.Count];
          
        for (int i = 0; i < PlayerList.Count; i++)
        {
            GameObject temp = Instantiate(PlayerList[i].player_prefab,transform.position,Quaternion.identity);
            temp.transform.parent = transform;
            player_list[i] = temp;

            if(PlayerList[i].player_id==0)
            {
                default_player_id = i;
            }

           
        }

        ActiveDefaultPlayer();

    }


    private void ActiveDefaultPlayer()
    {
        for(int i=0;i<player_list.Length;i++)
        {
            if(player_list[i].activeSelf)
            {
                player_active = true;
                break;
            }
           
        }

        if(player_active==false)
        {
            player_list[default_player_id].SetActive(true);
            player_active = true;

        }

    }

    public void nextPlayerActive()
    {
        for (int i = 0; i < player_list.Length;i++)
        {
            if(player_list[i].activeSelf)
            {
                currently_active_index = i;
                break;
            }

        }


    }





    public void nextButtonClicked()
    {
        nextPlayerActive();


        player_list[currently_active_index].SetActive(false);
        currently_active_index++;
        if(currently_active_index>=player_list.Length)
        {
            currently_active_index = 0;
        }

        player_list[currently_active_index].SetActive(true);




    }

    public void PreviousbuttonClicked()
    {
        nextPlayerActive();

       
         player_list[currently_active_index].SetActive(false);
           

            currently_active_index--;
        if(currently_active_index<=-1)
        {
            currently_active_index = player_list.Length - 1;
        }
            

            player_list[currently_active_index].SetActive(true);



    }

    public void ConfirmButtonClicked()
    {

    }









}//playerSpawner Class
