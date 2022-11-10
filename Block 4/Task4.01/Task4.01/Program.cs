using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace Task4._01
{
    class Bash
    {
        Hashtable localVariables;
        int returnCode;

        public Bash()
        {
            localVariables = new Hashtable();
            returnCode = 0;
        }

        public void executeCommands(string commandLine)
        {
            var commands = commandLine.Split(';');
            for (var i = 0; i < commands.Length; i++)
            {
                var splittedOnWhitespacesCommand = commands[i].Split(' ');
                var currCommand = splittedOnWhitespacesCommand[0];
                if (splittedOnWhitespacesCommand.Length == 1)
                {
                    executeOneCommand(commands[i], new string[0]);
                }
                else
                {
                    var currArgs = new string[splittedOnWhitespacesCommand.Length - 1];
                    for (var j = 0; j < splittedOnWhitespacesCommand.Length - 1; j++)
                    {
                        currArgs[j] = splittedOnWhitespacesCommand[j + 1];
                    }
                    executeOneCommand(splittedOnWhitespacesCommand[0], currArgs);
                }

            }

        }

        private void executeOneCommand(string command, string[] args)
        {
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == "||" || args[i] == "&&")
                {
                    var leftCommand = command;
                    var leftArgs = new string[i];
                    for (var j = 0; j < i; j++)
                    {
                        leftArgs[j] = args[j];
                    }
                    executeOneCommand(leftCommand, leftArgs);
                    if ((args[i] == "||" && returnCode == 0) || (args[i] == "&&" && returnCode != 0))
                    {
                        return;
                    }

                    if (i + 1 == args.Length)
                    {
                        Console.WriteLine("Invalid arg\n");
                        return;
                    }
                    var rightCommand = args[i + 1];
                    var rightArgs = new string[args.Length - i - 2];
                    for (var j = i + 2; j < args.Length; j++)
                    {
                        rightArgs[j - (i + 2)] = args[j];
                    }
                    executeOneCommand(rightCommand, rightArgs);
                    return;
                }

                if (args[i] == "?")
                {
                    args[i] = returnCode.ToString();
                }
                if (args[i].Length > 0)
                {
                    if (args[i][0] == '$')
                    {
                        if (localVariables.Contains(args[i].Substring(1, args[i].Length - 1)))
                        {
                            args[i] = (string)localVariables[(args[i].Substring(1, args[i].Length - 1))];
                        }
                    }
                }
            }

            switch (command)
            {
                case "pwd":
                    var path = Directory.GetCurrentDirectory();
                    Console.WriteLine("The current directory is {0}", path);
                    returnCode = 0;
                    break;

                case "cat":
                    try
                    {
                        var ph = args[0];
                        using (var reader = new StreamReader(ph))
                        {
                            var fileText = reader.ReadToEnd();
                            Console.WriteLine(fileText);
                            returnCode = 0;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid argument of command cat.\n");
                        returnCode = 1;
                    }
                    break;

                case "echo":
                    for (var j = 0; j < args.Length; j++)
                    {
                        Console.WriteLine(args[j]);
                    }
                    returnCode = 0;
                    break;

                case "true":
                    returnCode = 0;
                    break;

                case "false":
                    returnCode = 1;
                    break;

                // Присваивание и использование локальных переменных сессии (например $ a = 4).
                case "$":
                    if (args[1] == "=")
                    {
                        try
                        {
                            localVariables.Add(args[0], args[2]);
                        }
                        catch (Exception e)
                        { 

                        }
                        returnCode = 0;
                    }
                    else
                    {
                        Console.WriteLine("Command $ not found.\n");
                        returnCode = 1;
                    }
                    break;



                // Перенаправление ввода/вывода.


                // Если файл не существует, то он создаётся, а если существует, то перезаписывается.
                case ">":
                    string fileP = args[0];
                    if (!File.Exists(fileP))
                    {
                        using (StreamWriter sw = File.CreateText(fileP))

                            sw.Close();

                    }
                    else
                    {
                        FileInfo fileInf = new FileInfo(fileP);
                        if (fileInf.Exists)
                        {
                            fileInf.Delete();
                            using (StreamWriter sw = File.CreateText(fileP))

                                sw.Close();
                        }
                    }
                    break;


                // Если файл не существует, то он создаётся, а если существует, то данные дописываются в конец файла.
                case ">>":

                    string filePath = args[0];
                    if (!File.Exists(filePath))
                    {
                        using (StreamWriter sw = File.CreateText(filePath))
                            sw.Close();

                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(filePath))

                            sw.Close();

                    }

                    break;

                // Показываем на экране количество строк, слов и байт в файле.
                case "WC":
                   /* var p = args[0];
                    StreamReader read = new StreamReader(p);
                    int countStr = File.ReadAllLines(p).Length;
                    string st = "";
                    string[] textMass;
                    while (read.EndOfStream != true)
                    {
                        st += read.ReadLine();
                    }
                    textMass = st.Split(' ');
                    int countWrd = textMass.Length;
                    Console.WriteLine("Количество строк = {0}", countStr);
                    Console.WriteLine("Количество слов = {0}", countWrd);
                    returnCode = 0;
                   */

                    try
                    {
                        var p = args[0];
                        using (var read = new StreamReader(p))
                        {
                            int countStr = File.ReadAllLines(p).Length;
                            string st = "";
                            string[] textMass;
                            while (read.EndOfStream != true)
                            {
                                st += read.ReadLine();
                            }
                            textMass = st.Split(' ');
                            int countWrd = textMass.Length;
                            Console.WriteLine("Количество строк = {0}, количество слов = {1}", countStr, countWrd);
                            returnCode = 0;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid argument of command WC.\n");
                        returnCode = 1;
                    }







                    break;

                default:
                    Console.WriteLine("This command doesn't exist. Read the documentation and try again.");
                    returnCode = 1;
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bash = new Bash();

            while (true)
            {
                var x = Console.ReadLine();
                if (x == "exit")
                {
                    return;
                }
                bash.executeCommands(x);
            }

        }
















            }




















        }


