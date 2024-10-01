using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private SOCard soCard;
    [SerializeField] private Color color;

    [SerializeField] private SpriteRenderer cardSpriteRenderer;
    [SerializeField] private SpriteRenderer cardSpriteSpriteRenderer;

    [SerializeField] private bool _isFaceDown;

    [SerializeField] private GameObject backCard;

    private void Start()
    {
        


    }

    private void SetupCardVisuals()
    {
        cardSpriteRenderer.color = color;
        cardSpriteSpriteRenderer.sprite = soCard.sprite;
    }

    private void isFaceDown(bool face)
    {
        _isFaceDown = face;
        backCard.SetActive(face);
    }

}
