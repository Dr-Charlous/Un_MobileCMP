using UnityEngine;
using UnityEngine.UI;

public class FolderDisplay : MonoBehaviour
{
    [SerializeField] GameObject _buttons;
    [SerializeField] GameObject[] _views;
    [SerializeField] GameObject _charaViews;
    [SerializeField] GameObject[] _viewsChara;

    private void Start()
    {
        for (int i = 0; i < _views.Length; i++)
        {
            _views[i].SetActive(false);
        }

        for (int i = 0; i < _viewsChara.Length; i++)
        {
            _viewsChara[i].SetActive(false);
        }

        _charaViews.SetActive(false);
        _buttons.SetActive(true);
        _views[0].SetActive(true);
    }

    public void DisplayBigOnes(GameObject obj)
    {
        _buttons.SetActive(true);

        for (int i = 0; i < _views.Length; i++)
        {
            _views[i].SetActive(false);
        }

        obj.SetActive(true);
    }

    public void Display(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    public void CharaButton(Character chara)
    {
        _buttons.SetActive(false);

        for (int i = 0; i < _views.Length; i++)
        {
            _views[i].SetActive(false);
        }

        _charaViews.SetActive(true);
        _charaViews.GetComponent<CharaPage>().Character = chara;
        _charaViews.GetComponent<CharaPage>().Initialize();
    }

    public void DisplayBigOnesChara(GameObject obj)
    {
        for (int i = 0; i < _viewsChara.Length; i++)
        {
            _viewsChara[i].SetActive(false);
        }

        obj.SetActive(true);
    }
}