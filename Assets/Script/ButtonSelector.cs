using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI; 

public class ButtonSelector : MonoBehaviour
{
    public Button[] buttons; // ボタンの配列
    private int selectedIndex = 0; // 現在の選択インデックス

    [SerializeField] GameObject selectTriangle; //選択マークの▼

    void Start()
    {
        UpdateButtonSelection(); // 初期選択の更新
    }

    void Update()
    {
        // 上下キーで選択ボタンを切り替え
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            selectedIndex = (selectedIndex - 1 + buttons.Length) % buttons.Length; // 上に移動
            UpdateButtonSelection();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            selectedIndex = (selectedIndex + 1) % buttons.Length; // 下に移動
            UpdateButtonSelection();
        }

        // Enterキーで選択したボタンをクリック
        if (Input.GetKeyDown(KeyCode.Return))
        {
            buttons[selectedIndex].onClick.Invoke(); // ボタンのクリックイベントを呼び出す
        }
    }

    private void UpdateButtonSelection()
    {
        // ボタンの選択状態を更新
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == selectedIndex)
            {
                buttons[i].Select(); // 選択状態にする
                // 矢印の位置を更新
                Vector3 buttonPosition = buttons[i].GetComponent<RectTransform>().position;
                selectTriangle.transform.position = new Vector3(buttonPosition.x-70 , buttonPosition.y , buttonPosition.z); // 横に50、下に-32移動
               //buttons[i].GetComponent<Image>().color = Color.yellow; // 選択中のボタンの色を変更
            }
            else
            {
               // buttons[i].GetComponent<Image>().color = Color.white; // 通常の色
            }
        }
    }
}
