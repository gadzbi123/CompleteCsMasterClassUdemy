using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StacksQueues
{
    // key - data
    // auto - car
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(6);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());
            while (stack.Count > 0)
                stack.Pop();
            // Console.WriteLine(stack.Peek());

            Console.WriteLine("===================");
            int[] numbers = new int[] { 2, 8, 2, 80, 245, 1679, 21 };
            Stack<int> myStack = new Stack<int>();
            foreach (int num in numbers)
            {
                myStack.Push(num);
            }
            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());

            Console.WriteLine("-------------");
            /////////////////////////////////////////////Queue
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            Console.WriteLine("Value next:{0}", queue.Peek());
            queue.Enqueue(6);
            Console.WriteLine("Value next:{0}", queue.Peek());
            int Qitem = queue.Dequeue();
            Console.WriteLine("Item {0}", Qitem);
            Console.WriteLine("Value next:{0}", queue.Peek());
            Console.WriteLine("===================");
            Queue<Order> qOrders = new Queue<Order>();
            foreach (Order o in ReciveOrdersFromBranch1())
            {
                qOrders.Enqueue(o);
            }
            foreach (Order o in ReciveOrdersFromBranch2())
            {
                qOrders.Enqueue(o);
            }
            while (qOrders.Count > 0)
            {
                Order currOrder = qOrders.Dequeue();
                currOrder.ProcessOrder();
            }
        }

        static Order[] ReciveOrdersFromBranch1()
        {
            Order[] order = new Order[] { new Order(1, 5), new Order(2, 4), new Order(6, 19) };
            return order;
        }

        static Order[] ReciveOrdersFromBranch2()
        {
            Order[] order = new Order[] { new Order(3, 5), new Order(4, 4), new Order(5, 19) };
            return order;
        }
    }

    class Order
    {
        //property Id
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
