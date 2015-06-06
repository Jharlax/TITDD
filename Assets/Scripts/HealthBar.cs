#region Usings

using UnityEngine;
using System.Text;
using System.Collections;

#endregion

public class HealthBar : MonoBehaviour
{
    #region Fields

    public int StartHealthPoints;

    private TextMesh m_TextMesh;
    private int m_CurrentHealthPoints;

    #endregion

    #region From API

    // Use this for initialization
    void Start ()
    {
        m_TextMesh = GetComponent<TextMesh>();
        SetHealthText(StartHealthPoints);
        m_CurrentHealthPoints = StartHealthPoints;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Face the Camera
        HealthTextFacesCamera();
    }

    #endregion

    #region Public Methods

    public void decreaseHealthPoints()
    {
        m_CurrentHealthPoints--;
        
        if(m_CurrentHealthPoints == 0)
        {
            DestroyHealthBarParent();
        }

        SetHealthText(m_CurrentHealthPoints);
    }

    #endregion

    #region Private Methods
    private void SetHealthText(int numberOfHelathPoints)
    {
        StringBuilder healtText = new StringBuilder();
        for(int i = 0; i < numberOfHelathPoints; i++)
        {
            healtText.Append("-");
        }
        m_TextMesh.text = healtText.ToString();
    }

    private void HealthTextFacesCamera()
    {
        transform.forward = Camera.main.transform.forward;
    }

    private void DestroyHealthBarParent()
    {
        Destroy(transform.parent.gameObject);
    }
    #endregion
}
