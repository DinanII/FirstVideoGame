using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score : MonoBehaviour
{
    public Transform player;
    public TMP_Text m_TextComponent;
    // Update is called once per frame
    void Update()
    {
        m_TextComponent = GetComponent<TMP_Text>();

        // Change the text on the text component.
        m_TextComponent.text = player.position.z.ToString("0");
    }
}
