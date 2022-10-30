using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubController : MonoBehaviour
{
    [HideInInspector]
    public UIRootController root;

    public virtual void EnableUIController()
    {
        gameObject.SetActive(true);
    }

    public virtual void DisableUIController()
    {
        gameObject.SetActive(false);
    }
}

/// <summary>
/// Расширение класса подконтроллера с обобщенной ссылкой на UI Root.
/// </summary>
public abstract class SubController<T> : SubController where T : UIRoot
{
    [SerializeField]
    protected T ui;
    public T UI => ui;

    public override void EnableUIController()
    {
        base.EnableUIController();

        ui.ShowRoot();
    }

    public override void DisableUIController()
    {
        base.DisableUIController();

        ui.HideRoot();
    }
}
