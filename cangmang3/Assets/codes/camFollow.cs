using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform character;

    private void FixedUpdate()
    {
      if(character!= null)
        transform.position = new Vector3(character.position.x + 5.85f, 0, -6.2f);
    }

   
}
