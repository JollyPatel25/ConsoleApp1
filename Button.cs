using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Button
    {
        public delegate void ButtonClick(String msg);
        public event ButtonClick OnClick;
        public void buttonClicked(ConsoleKeyInfo key)
        {
            OnClick?.Invoke(key.Key + " Key Is Clicked!");
        }
    }
}
