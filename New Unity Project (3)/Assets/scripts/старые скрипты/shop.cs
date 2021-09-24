
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    private void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;
        for (int i = 0; i< 10; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
        }
        Destroy(ItemTemplate);
    }
}
