using UnityEngine;


public class EnterToBuilding : MonoBehaviour
{
    [SerializeField] private GameObject tipCanvas;

    private void Start()
    {
        tipCanvas.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnterableBuilding building))
        {
            tipCanvas.SetActive(true);
            if(Input.GetKey(KeyCode.E)) 
            {
                Debug.Log("Ты лох");
                building.EnterToBuilding();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnterableBuilding building))
        {
            tipCanvas.SetActive(false);
        }
    }
    
}
