using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string operation = commands[0];
                string message = commands[1];

                if (operation == "Chat")
                {
                    chat.Add(message);
                }
                else if (operation == "Delete")
                {
                    if(chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (operation == "Edit")
                {
                    string editedVersion = commands[2];
                    if (chat.Contains(message))
                    {
                        int index = chat.IndexOf(message);
                        chat.Remove(message);
                        chat.Insert(index, editedVersion);
                    }
                }
                else if (operation == "Pin")
                {
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                        chat.Add(message);
                    }
                }
                else if (operation == "Spam")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        string messageN = commands[i];
                        chat.Add(messageN);
                    }
                }
            }
            Console.WriteLine(string.Join(System.Environment.NewLine , chat));
        }
    }
}
