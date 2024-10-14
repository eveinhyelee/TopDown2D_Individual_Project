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

    [Header("�÷��̾� �̸�")]
    [SerializeField] private TMP_Text uesrNameText;
    [SerializeField] private GameObject UesrName;

    [SerializeField] private GameObject NameChangePanel;
    [SerializeField] private TMP_InputField changeNameInput;

    [Header("���� �ð�")]
    [SerializeField] private TextMeshProUGUI displayTime;

    [Header("ĳ����")]
    [SerializeField] private Button characterChangeBtn;
    [SerializeField] private GameObject characterChangePanel;

    [Header("ä�ú���")]
    [SerializeField] private Button ChatShowBtn;
    [SerializeField] private Button ChatHideBtn;
    [SerializeField] private GameObject ChatPanel;

    private GameObject timeTxt;

    void Start()
    {
        uesrNameText.text = PlayerPrefs.GetString("userName");
    }

    private void Update()
    {
        
    }

    public void ChangeID()
    {
        if (PlayerPrefs.HasKey("userName"))
        {
            PlayerPrefs.DeleteKey("userName");
            changeNameInput.onEndEdit.AddListener(delegate { ChangeIDSet(); });
        }
    }

    public void ChangeIDSet()
    {
        if (changeNameInput.text.Length < 2 || changeNameInput.text.Length > 10)
        {
            changeNameInput.text = string.Empty;
            return;
        }
        PlayerPrefs.SetString("userName", changeNameInput.text);
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
        uesrNameText.text = changeNameInput.text;
    }
}


