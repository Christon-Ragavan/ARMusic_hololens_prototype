using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{


    public List<Texture> m_Textures = new List<Texture>();

    private Material m_Material;

    private int m_CurrentTexture = 0;

    // Use this for initialization
    void Start()
    {
        m_Material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextTexture()
    {
        m_CurrentTexture = Mathf.Clamp(m_CurrentTexture + 1, 0, m_Textures.Count - 1);

        m_Material.mainTexture = m_Textures[m_CurrentTexture];
    }
    public void PreviousTexture()
    {
        m_CurrentTexture = Mathf.Clamp(m_CurrentTexture - 1, 0, m_Textures.Count - 1);

        m_Material.mainTexture = m_Textures[m_CurrentTexture];
    }

}