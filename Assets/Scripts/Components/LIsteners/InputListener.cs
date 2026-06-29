using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.Listeners
{
    public class InputListener : MonoBehaviour
    {
        // 1. Передаем сам ассет
        [SerializeField] private InputActionAsset inputActionAsset;

        // 2. Выбор карты ввода из назначенного выше ассета
        [SerializeField] // Атрибут связывает поле с инстансом ассета
        private string actionMapName;

        // 3. Структура для выбора конкретного Action
        // Она автоматически отобразит удобный выпадающий список в инспекторе,
        // где можно выбрать абсолютно любое действие (или отфильтровать по карте)
        [SerializeField] private InputActionProperty specificAction;
    }
}