using System;

namespace Delegate_Event
{

    //新建的GreetingManager类
    public class GreetingManager
    {
        public delegate void GreetingDelegate(string name);
        public event GreetingDelegate greetingEvent;

        public void OnGreetPeople(string name)
        {
            greetingEvent(name);
        }
    }

    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        static void Main(string[] args)
        {
            GreetingManager gm = new  GreetingManager();
            gm.greetingEvent += EnglishGreeting;
            gm.greetingEvent += ChineseGreeting;

            gm.OnGreetPeople("Jimmy Zhang");
        }

    }
}