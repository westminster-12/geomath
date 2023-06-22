using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sidePanelOpen : MonoBehaviour
{
    private Animator panelAnimator;
    private bool isOpen = false;

    void Start()
    {
        panelAnimator = this.GetComponent<Animator>();
    }

    public void openMenu()
    {
        panelAnimator.Play("Friends Panel In");
    }

    public void closeMenu()
    {
        panelAnimator.Play("Friends Panel Out");
    }
}