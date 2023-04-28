using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanceur : MonoBehaviour
{
    private Rigidbody2D rig;
    private Vector2 vit;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = vit;
    }

    public void Lancer(Vector2 vitesse)
    {
        vit = vitesse;
    }
}
