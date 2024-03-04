using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OpenPanel : MonoBehaviour
{
    public RectTransform newsPanel, rockPanel, stampPanel, scriptPanel;
    public AudioSource scriptin;

    private void Start()
    {
        scriptin = GetComponent<AudioSource>();
        
    }

    public void PanelBtn(string panelName)
    {
        if (panelName == "News")
        {
            if (newsPanel.localPosition.x == 640)   // 뉴스 열기
            {
                뉴스.isOpen = true;
                newsPanel.DOLocalMoveX(70, 2f).SetEase(Ease.OutBack);
            }
            else if (newsPanel.localPosition.x == 70)   // 뉴스 닫기
            {
                newsPanel.DOLocalMoveX(640, 2f).SetEase(Ease.InBack);
            }
        }

        else if (panelName == "Rock")
        {
            if (rockPanel.localPosition.x == 550)
            {
                rockPanel.DOLocalMoveX(335, 1f).SetEase(Ease.OutBack);
            }
            else if (rockPanel.localPosition.x == 335)
            {
                rockPanel.DOLocalMoveX(550, 1f).SetEase(Ease.InBack);
            }
        }

        else if (panelName == "Stampbox")
        {
           stampPanel.DOLocalMoveX(323, 1f).SetEase(Ease.OutBack);
        }

        else if (panelName == "Script")
        {
            scriptin.Play();

            if(scriptPanel.localPosition.y == -347){
                scriptPanel.DOLocalMoveY(20, 2f).SetEase(Ease.OutBack);
            }
        }
    }
    public void StampBack(){
        stampPanel.DOLocalMoveX(578, 1f).SetEase(Ease.InBack);
    }
}
