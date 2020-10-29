using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform Background1;
    public Transform Background2;
    public Transform Zemin1;
    public Transform Zemin2;
    public Transform UstZemin1;
    public Transform UstZemin2;

    private bool Whichone = true;

    public Transform cam;

    private float currrentWidth = 12.80f;


    // Update is called once per frame
    void Update()
    {
        if (currrentWidth < cam.position.x)
        {
            if (Whichone)
            {
                Background2.localPosition = new Vector3(Background2.localPosition.x + 25.6f, 0, 0);
                Zemin1.localPosition = new Vector3(Zemin1.localPosition.x + 25.6f, -2.87f, 0);
                UstZemin1.localPosition = new Vector3(UstZemin1.localPosition.x + 25.6f, UstZemin1.localPosition.y, 0);
            }
            else
            {
                Background1.localPosition = new Vector3(Background1.localPosition.x + 25.6f, 0, 0);
                Zemin2.localPosition = new Vector3(Zemin2.localPosition.x + 25.6f, -2.87f, 0);
                UstZemin2.localPosition = new Vector3(UstZemin2.localPosition.x + 25.6f, UstZemin2.localPosition.y, 0);
            }

            currrentWidth += 12.8f;

            Whichone = !Whichone;
        }


        if (currrentWidth > cam.position.x + 12.8)
        {
            if (Whichone)
            {
                Background1.localPosition = new Vector3(Background1.localPosition.x - 25.6f, 0, 0);
                Zemin2.localPosition = new Vector3(Zemin2.localPosition.x - 25.6f, -2.87f, 0);
                UstZemin2.localPosition = new Vector3(UstZemin2.localPosition.x - 25.6f, UstZemin2.localPosition.y, 0);
            }
            else
            {
                Background2.localPosition = new Vector3(Background2.localPosition.x - 25.6f, 0, 0);
                Zemin1.localPosition = new Vector3(Zemin1.localPosition.x - 25.6f, -2.87f, 0);
                UstZemin1.localPosition = new Vector3(UstZemin1.localPosition.x - 25.6f, UstZemin1.localPosition.y, 0);
            }

            currrentWidth -= 12.8f;

            Whichone = !Whichone;
        }
    }
}

