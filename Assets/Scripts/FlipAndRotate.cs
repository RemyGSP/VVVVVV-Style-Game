using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipAndRotate : MonoBehaviour
{
    // Start is called before the first frame update
    
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void FlipY()
    {
        if (_spriteRenderer.flipY)
        {
            _spriteRenderer.flipY = false;
        }
        else
        {
            _spriteRenderer.flipY = true;
        }
    }

    public void FlipX()
    {
        if (_spriteRenderer.flipX)
        {
            _spriteRenderer.flipX = false;
        }
        else
        {
            _spriteRenderer.flipX = true;
        }
    }
}
