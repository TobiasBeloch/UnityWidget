using UnityEngine;

public class UI_InventoryController : MonoBehaviour
{
    [SerializeField]
    private UI_InventoryPage UI_inventory;
    public int inventorySize = 10;

    private void Start()
    {
        UI_inventory.UI_InitializeInventory(inventorySize);
    }

    public void Update()
    {
        //logika kdy ma byt ukazanej inventar
    }
}
