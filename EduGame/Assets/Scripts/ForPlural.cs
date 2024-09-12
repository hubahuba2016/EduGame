using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPlural : MonoBehaviour
{
    public PluralSingularController controller_script;
   void Start()
    {
        controller_script = GameObject.Find("World").GetComponent<PluralSingularController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (controller_script.game_is_singular==false && controller_script.game_is_plural==true)
        {
            Destroy(this.gameObject);
        }
    }
}
