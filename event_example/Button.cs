using System;

namespace delegate_event_example
{
    class Button
    {
        public delegate void Notification(String msg);
        public event Notification ClickEvent;

        public void OnClick(String text)
        {
            ClickEvent?.Invoke(text);
        }
    }
}
