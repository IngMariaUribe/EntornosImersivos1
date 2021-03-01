using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUICintroller : MonoBehaviour
{
    private string[] objects = { "Bed", "Wood", "Chair","Box" };
    private int valor;
    public Text DirectorText;
    // Start is called before the first frame update
    void Start()
    {
        valor = 0;
        DirectorText.text = "Find a " + objects[valor];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
       
            
        if (collision.gameObject.tag == objects[valor])
        {
            if (valor < 3)
            {
                valor++;
                DirectorText.text = "Find a " + objects[valor];
                Debug.Log(valor);
            }else
            {
                DirectorText.text = "You have found all the objects";
            }
        }
       
    }

}
