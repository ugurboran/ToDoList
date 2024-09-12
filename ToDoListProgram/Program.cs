using System;
using System.Collections.Generic;

class ToDoListProgram
{
    static List<string> todoList = new List<string>();

    static void Main(string[] args)
    {
        bool continueApp = true;

        while (continueApp)
        {
            Console.Clear();
            Console.WriteLine("=== TODO LIST UYGULAMASI ===");
            Console.WriteLine("1. Görev Ekle");
            Console.WriteLine("2. Görevleri Listele");
            Console.WriteLine("3. Görevi Tamamla");
            Console.WriteLine("4. Çıkış");
            Console.Write("Bir seçenek seçiniz: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    continueApp = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek. Devam etmek için bir tuşa basın.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Clear();
        Console.Write("Yeni görev girin: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine("Görev eklendi! Devam etmek için bir tuşa basın.");
        Console.ReadKey();
    }

    static void ShowTasks()
    {
        Console.Clear();
        Console.WriteLine("=== GÖREVLER ===");

        if (todoList.Count == 0)
        {
            Console.WriteLine("Henüz eklenmiş bir görev yok.");
        }
        else
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }

        Console.WriteLine("Devam etmek için bir tuşa basın.");
        Console.ReadKey();
    }

    static void CompleteTask()
    {
        Console.Clear();
        ShowTasks();

        if (todoList.Count == 0)
        {
            return;
        }

        Console.Write("Tamamlanan görevin numarasını girin: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int taskIndex) && taskIndex > 0 && taskIndex <= todoList.Count)
        {
            todoList.RemoveAt(taskIndex - 1);
            Console.WriteLine("Görev tamamlandı! Devam etmek için bir tuşa basın.");
        }
        else
        {
            Console.WriteLine("Geçersiz numara. Devam etmek için bir tuşa basın.");
        }

        Console.ReadKey();
    }
}
