using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSingular : MonoBehaviour
{
    public PluralSingularController controller_script;
    // Start is called before the first frame update
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
        if (controller_script.game_is_singular==true && controller_script.game_is_plural==false)
        {
            Destroy(this.gameObject);
        }
    }
}
