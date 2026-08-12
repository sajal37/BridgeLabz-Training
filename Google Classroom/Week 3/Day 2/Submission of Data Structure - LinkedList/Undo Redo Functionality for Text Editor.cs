using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Undo_Redo_Functionality_for_Text_Editor
    {
        public static void Main(string[] args)
        {
            TextEditorHistory editor1 = new TextEditorHistory(10);

            editor1.AddState("Hello");
            editor1.AddState("Hello World");
            editor1.AddState("Hello World!");

            Console.WriteLine("Current Text State:");
            editor1.DisplayCurrent();

            Console.WriteLine("\nPerforming Undo:");
            editor1.Undo();
            editor1.DisplayCurrent();

            Console.WriteLine("\nPerforming Undo Again:");
            editor1.Undo();
            editor1.DisplayCurrent();

            Console.WriteLine("\nPerforming Redo:");
            editor1.Redo();
            editor1.DisplayCurrent();

            Console.WriteLine("\nTyping new text (overwriting redo history):");
            editor1.AddState("Hello C# Developer");
            editor1.DisplayCurrent();
        }
    }

    class TextStateNode
    {
        public string textContent;
        public TextStateNode prev;
        public TextStateNode next;

        public TextStateNode (string textContent)
        {
            this.textContent = textContent;
            this.prev = null;
            this.next = null;
        }
    }

    class TextEditorHistory
    {
        private TextStateNode head;
        private TextStateNode tail;
        private TextStateNode current;
        private int maxCapacity;
        private int currentSize;

        public TextEditorHistory (int capacity)
        {
            this.maxCapacity = capacity;
            this.currentSize = 0;
        }

        public void AddState(string newText)
        {
            TextStateNode newNode = new TextStateNode(newText);
            if (head == null)
            {
                head = tail = current = newNode;
                currentSize = 1;
                return;
            }

            // Discard forward redo history if adding from middle
            current.next = newNode;
            newNode.prev = current;
            current = tail = newNode;

            // Recalculate size
            int size = 0;
            TextStateNode temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            currentSize = size;

            // Enforce max capacity limit
            if (currentSize > maxCapacity)
            {
                head = head.next;
                if (head != null) head.prev = null;
                currentSize--;
            }
        }

        public void Undo()
        {
            if (current != null && current.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Undo successful.");
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Redo()
        {
            if (current != null && current.next != null)
            {
                current = current.next;
                Console.WriteLine("Redo successful.");
            }
            else
            {
                Console.WriteLine("Nothing to redo.");
            }
        }

        public void DisplayCurrent()
        {
            if (current != null)
            {
                Console.WriteLine($"State Text: \"{current.textContent}\"");
            }
            else
            {
                Console.Write("Editor is Empty");
            }
        }
    }
}
