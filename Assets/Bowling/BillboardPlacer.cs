using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeCoaching;

public class BillboardPlacer : MonoBehaviour
{
    [SerializeField] List<string> urls;
    [SerializeField] float maxSize = 10;
    float offset;
    [SerializeField] GameObject billboardPrefab;

    void Start()
    {
        for (int i = 0; i < urls.Count; i++)
        {
            CreateBillBoard(urls[i], i);
        }
    }

    private void CreateBillBoard(string url, int listIndex = 0)
    {
        StartCoroutine(Request.getImage(url, (response) =>
        {
            // Create
            GameObject board = Instantiate(billboardPrefab, transform);
            board.name = $"Billboard{listIndex+1} ({response.width}x{response.height})";
            // Modify
            float width = response.width;
            float height = response.height;

            board.GetComponent<Renderer>().material.mainTexture = response;
            board.transform.localPosition = new Vector3(0, 0, width/2 + offset);
            board.transform.localScale = new Vector3(width, 1, height);
        /*
            float width = response.width;
            float height = response.height;
            GameObject original = targetObject;
            if (targetObject.scene.IsValid()) targetObject.SetActive(false);
            GameObject image = Instantiate(original);
            image.transform.rotation = original.transform.rotation;
            if (width > height)
            {
                float ratio = (float)width / height;
                width = 2;
                height = width / ratio;
            }
            else
            {
                float ratio = (float)height / width;
                height = 2;
                width = height / ratio;
            }

            //if(scaleOnZ) image.transform.localScale = new Vector3(width, 0.01f, height);
            //else image.transform.localScale = new Vector3(width, height, 0.01f);

            image.transform.position = new Vector3(original.transform.position.x, original.transform.position.y, original.transform.position.z); // waar in de wereld moet de afbeelding komen
            //image.transform.eulerAngles = setRotation;

            //image.GetComponent<Renderer>().material.mainTexture.wrapMode = TextureWrapMode.Repeat;
            image.GetComponent<Renderer>().material.mainTexture = response;
            image.SetActive(true);
        */
        }));

    }
}
