
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{

    private float hp;
    
    public float Hp { get => SliderHP.value; set => hp = value; }

    //練習1
    [Header("滑桿")]
    public Slider SliderHP;
    [Header("滑桿結果")]
    public Text resultS;

    //練習2
    [Header("輸入欄位")]
    public InputField inp;
    [Header("輸入結果")]
    public Text resultI;

    //練習3
    [Header("方塊")]
    public GameObject cube;





    private void Update()
    {

        if (Hp <= 30)
        {
            resultS.text = "危險";
        }
        else if (Hp <= 70)
        {
            resultS.text = "警告";
        }
        else
        {
            resultS.text = "安全";
        }


        resultI.text = inp.text == "紅水" ? "恢復血量" : inp.text == "藍水" ? "恢復魔力" : "錯誤的資料";

        }

    private void Start()
    {
        for (int i = 0; i< 10; i++)
        {
            for (int j = 0; j < (i+1); j++) 
            
            {
                Vector3 pos = new Vector3(i * 2, j * 2, 25);
                Instantiate(cube, pos, Quaternion.identity);
            }
                        
        }
    }



}
