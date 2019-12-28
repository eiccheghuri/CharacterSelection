using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="new player",menuName ="Game Objects/Player Object")]
public class PlayerObject : ScriptableObject
{

    public GameObject player_prefab;
    public string player_name;
    public int player_health;
    public int missile_number;
    public int player_id;

    

}
