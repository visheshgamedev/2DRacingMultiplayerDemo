using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private Vector3[] carSpawnPostion;
    [SerializeField] private Sprite[] carSprites;
    private void Awake()
    {
        
        GameObject car = PhotonNetwork.Instantiate("Car", carSpawnPostion[PhotonNetwork.CountOfPlayersInRooms], Quaternion.identity);
        car.GetComponent<Car>().currentPlayerMarker.SetActive(true);
        car.GetComponentInChildren<SpriteRenderer>().sprite = carSprites[PhotonNetwork.CountOfPlayersInRooms];
    }
}