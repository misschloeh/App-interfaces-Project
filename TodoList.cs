using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;
    
    public string HeaderSymbol {
      get {
        return "----------";
      }
    }

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    { if (Todos.Length <= 5)
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

    public void Display() {
      Console.WriteLine("ToDo List");
      Console.WriteLine(HeaderSymbol);
      foreach(string todo in Todos) {
        if (String.IsNullOrEmpty(todo)) {
          Console.WriteLine("[]");
        } else {
        Console.WriteLine(todo);
      }
    }
    }

    public void Reset() {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

  }
}