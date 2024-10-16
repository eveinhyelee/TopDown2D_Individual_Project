using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class StartUISet : MonoBehaviour
{    
    [SerializeField] private TMP_InputField NameInput;

    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject SelectCharPanel;

    [SerializeField] private Button SelectCharPanelBtn;
    [SerializeField] private Button SelectCharBtn1;
    [SerializeField] private Button SelectCharBtn2;
    
    [SerializeField] private Button StartBtn;    

    void Start()
    {
        MainPanel.SetActive(true);
        SelectCharPanelBtn = GetComponent<Button>();
        NameInput.onEndEdit.AddListener(delegate { CreateID(); });
    }
    
    void Update()
    {
        
    }
    public void CreateID()
    {
        if (NameInput.text.Length < 2 || NameInput.text.Length > 10)
        {
            NameInput.text = string.Empty;
            return;
        }

        PlayerPrefs.SetString("userName", NameInput.text);
        PlayerPrefs.Save();
    }
    public void OnSelectCharPanel() 
    {
        MainPanel.SetActive(false);
        SelectCharPanel.SetActive(true);
    }
    //동작안함
    public void SelecChar1()
    {
        SelectCharPanelBtn.image = SelectCharBtn1.image;        
    }
    //동작안함
    public void SelecChar2()
    {
        SelectCharPanelBtn.image = SelectCharBtn2.image;
    }
    public void OffSelectCharPanel() 
    {
        SelectCharPanel.SetActive(false);
        MainPanel.SetActive(true);
    }   

    //들어가기 클릭시, 플레이 씬 로드
    public void PlayToStart()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
