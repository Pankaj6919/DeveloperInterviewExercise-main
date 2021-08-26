using System;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SetOfTasks tasks = new SetOfTasks();
            
            Console.WriteLine(tasks.TaskOne(args));
            Console.WriteLine(tasks.TaskSecond(args));
            Console.ReadLine();
        }
    }
}
