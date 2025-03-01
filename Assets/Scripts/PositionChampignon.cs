using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChampignon : MonoBehaviour
{

    [SerializeField] GameObject _ileDrapeau;
    [SerializeField] GameObject _ileBoite;
    [SerializeField] float _rayonMax;

    private float _index;

    void Start()
    {
        InvokeRepeating("GenererNombreAlleatoire", 1f, 1f);
        InvokeRepeating("PositionChampi", 1f, 1f);
        
    }

    private void GenererNombreAlleatoire()
    {
        _index = Random.value;
    }

    private void PositionChampi()
    {
        Vector3 nouvellePosition = Vector3.zero;

        Vector2 variation = Random.insideUnitCircle * _rayonMax;

        nouvellePosition.x = variation.x;
        nouvellePosition.z = variation.y;

        if (_index> 0.5f)
        {
            transform.position = _ileDrapeau.transform.position;
        }
        else
        {
            transform.position = _ileBoite.transform.position + nouvellePosition;
        }
    }

}
