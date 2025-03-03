using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Wichtig: Um TextMeshPro zu nutzen

public class DistanceMeter : MonoBehaviour
{
    public Transform player;  // Spieler-Transform
    public TextMeshProUGUI meterText;  // Der Text, der die Meter anzeigt
    private Vector3 startPosition;  // Anfangsposition des Spielers

    void Start()
    {
        // Speichere die Startposition des Spielers, um die Distanz zu berechnen
        startPosition = player.position;
    }

    void Update()
    {
        // Berechne die zurückgelegte Distanz des Spielers (nur auf der X-Achse)
        float distance = Vector3.Distance(new Vector3(startPosition.x, 0, 0), new Vector3(player.position.x, 0, 0));

        // Aktualisiere den Text mit der Distanz, gerundet auf ganze Zahlen
        meterText.text = $"{Mathf.FloorToInt(distance).ToString()}m ";
    }
}
