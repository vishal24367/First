using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class FindOut : MonoBehaviour 
{
    public EnemyDatabase enemyDatabase;
    public InputField locationField;
    public Button locateButton;
    public Text locationText;

    public void InitFormView(System.Action<EnemyRequestData> callback)
    {
        locateButton.onClick.AddListener(()=>{
                OnCreateClicked(callback);
            }
        );
    }

    public void OnCreateClicked(System.Action<EnemyRequestData> callback)
    {
        if (InputsAreValid())
        {
            // var enemy = new EnemyRequestData(
            
            //     locationText.text
                
            // );
            
            // callback(enemy);
            // Debug.Log("Checking");
        }
        else
        {
            // Debug.LogWarning("Invalid Input");
        }
    }

    private bool InputsAreValid()
    {
        return !(string.IsNullOrEmpty(locationText.text));
    }

    public void locate()
    {
        
    }
}