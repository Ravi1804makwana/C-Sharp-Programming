using System;

namespace GenericsProgramming
{
    class NonGenericClass
    {
        public void Show<T>(params T[] list)
        {
            Console.WriteLine(String.Join(", ",list));
        }
    }
}
