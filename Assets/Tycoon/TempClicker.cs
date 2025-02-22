using TycoonSystem.Core;
using UnityEngine;
using UnityEngine.InputSystem;

public class TempClicker : MonoBehaviour
{
    [SerializeField] private AbstractCurrency m_baseCurrency;
    [SerializeField] private InputActionReference m_click;

    private void Awake()
    {
        m_click.action.performed += this.OnClick;
    }

    private void OnClick(InputAction.CallbackContext p_obj)
    {
        if (!p_obj.ReadValueAsButton())
            return;
        m_baseCurrency.Gain(1);
    }
}
