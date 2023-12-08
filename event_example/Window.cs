using System;

namespace delegate_event_example
{
    class Window
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Press 'a' key to simulate a button click");
            string key = Console.ReadLine();
            if (key == "a") 
            {
                ButtonPressed();
            }

            Console.Write("press any key to exit...");
            Console.ReadKey();
        }

        static void ButtonPressed()
        {
            Button button = new Button();
            button.ClickEvent += Button_ClickEvent;
            button.OnClick("Button has been clicked!");
        }

        private static void Button_ClickEvent(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
