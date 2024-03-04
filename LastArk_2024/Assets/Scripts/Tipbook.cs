using DG.Tweening;
using TMPro;
using UnityEngine;

public class Tipbook : MonoBehaviour
{
    public RectTransform book;  // 패널
    public GameObject prev, next;   // 이전, 다음 버튼
    public GameObject[] books;  // 사용방법 페이지 배열
    public int currentpage = 0; // 현재 페이지
    public TextMeshProUGUI ptext;   // 페이지 표시

    void Start()
    {
        Show(currentpage);
    }

    public void Open(){ // 설명서 열고 닫기
        if(book.localPosition.x == 605)
            book.DOLocalMoveX(50, 1f).SetEase(Ease.OutBack);
        else if(book.localPosition.x == 50)
            book.DOLocalMoveX(605, 1f).SetEase(Ease.InBack);
    }
    public void Prev(){ // 이전 페이지
        Debug.Log("dkr");
        currentpage--;
        if(currentpage >= 0){
            Show(currentpage);
        }
    }
    public void Next(){ // 다음 페이지
        currentpage++;
        if(currentpage < books.Length){
            Show(currentpage);
        }
    }
    void Show(int page){
        prev.SetActive(true);
        next.SetActive(true);

        foreach(GameObject tip in books){
            tip.SetActive(false);
        }

        if(page == 0)   // 맨 첫장
            prev.SetActive(false);
        else if(page == books.Length - 1)
            next.SetActive(false);  // 맨 마지막장
        
        books[page].SetActive(true);    // 해당 페이지만 보여주기
        ptext.text = (page + 1).ToString();
    }
}
