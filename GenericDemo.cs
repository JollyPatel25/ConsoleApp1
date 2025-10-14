using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericDemo<T>
    {
        T data;
        public void SetData(T data)
        {
            this.data = data;
        }
        public T GetData()
        {
            return this.data;
        }
        public void DisplayType()
        {
            Console.WriteLine($"The Type Of Data Is: {typeof(T)}");
        }
    }
}
