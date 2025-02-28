using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int pointsJeu = 0;

    public float tempsJeu = 0f;

    private int time;

    void Start()
    {
        pointsJeu = 0;
        tempsJeu = 0f;
        InvokeRepeating("AugmenterTemps", 1f, 0.01f);
    }

    public void AugmenterTemps()
    {
        tempsJeu+= 0.01f;
        _etiquetteTemps.text = tempsJeu.ToString("00.00") + "s";
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }
}
