using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class PlayMainUI : MonoBehaviour
{
    [SerializeField] private TMP_Text RoomNameText;

    [Header("플레이어 이름")]
    [SerializeField] private TMP_Text uesrNameText;
    [SerializeField] private GameObject UesrName;
    private string userName;

    [SerializeField] private GameObject NameChangePanel;
    [SerializeField] private TMP_InputField changeNameInput;

    [Header("현재 시간")]
    [SerializeField] private TextMeshProUGUI displayTime;

    [Header("캐릭터")]
    [SerializeField] private Button characterChangeBtn;
    [SerializeField] private GameObject characterChangePanel;

    [Header("채팅보기")]
    [SerializeField] private Button ChatShowBtn;
    [SerializeField] private Button ChatHideBtn;
    [SerializeField] private GameObject ChatPanel;

    private GameObject timeTxt;

    void Start()
    {
        userName = PlayerPrefs.GetString("userName");
        uesrNameText.text = userName;
    }
    
    public void ChangeID()
    {
        if (PlayerPrefs.HasKey("userName"))
        {
            PlayerPrefs.DeleteKey("userName");
        }
        changeNameInput.onEndEdit.AddListener(delegate { ChangeIDSet(changeNameInput); });
    }

    public void ChangeIDSet(TMP_InputField input)
    {   
        if (input.text.Length < 2 || input.text.Length > 10)
        {
            input.text = string.Empty;
            return;
        }
        PlayerPrefs.SetString("userName", input.text);
        PlayerPrefs.Save();
    }
    public void OnNameChangePanel()
    {
        UesrName.SetActive(false);
        NameChangePanel.SetActive(true);
    }
    public void OffNameChangePanel()
    {
        NameChangePanel.SetActive(false);
        UesrName.SetActive(true);
    }
}


