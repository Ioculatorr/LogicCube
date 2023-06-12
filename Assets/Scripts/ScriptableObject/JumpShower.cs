using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpShower : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public JumpCounter JumpCount;
    
    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        JumpCount.jumpsAmount = 0;
    }

    private void Update()
    {
        textMeshProUGUI.text = "Player jumps:" + JumpCount.jumpsAmount.ToString();
    }
}
