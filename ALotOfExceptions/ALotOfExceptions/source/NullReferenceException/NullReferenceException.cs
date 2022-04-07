using System;
using System.Collections.Generic;

namespace ALotOfExceptions;
    public static class NullReferenceException
    {
        public class StackFixed
        {
            public ICollection<List> Lists { get; set; }

            public StackFixed()
            {
                Lists = new List<List>();
            }
            
            public void Add(List list)
            {
                Lists.Add(list);
            }
        }

        public class Stack
        {
            public ICollection<List> Lists { get; set; }
        }

        public class List
        {
            public string Title { get; set; }

            public void setTitle(string title)
            {
                Title = title;
            }
        }

        // Новый Stack создает только экземпляр Stack,
        // но коллекция Lists по-прежнему пуста.
        // Синтаксис инициализатора коллекции не создает коллекцию для person.Lists,
        // он только преобразуется в операторы stack.Lists.Add(...).
        public static Stack MakeStackWithOneList(string title)
        {
            try
            {
                Stack stack = new Stack {Lists = {new List {Title = title}}};
                return stack;
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static StackFixed MakeStackWithOneListFixed(string title)
        {
            StackFixed stack = new StackFixed();
            List list = new List();
            list.setTitle(title);
            try
            {
                stack.Add(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return stack;
        }
    }
