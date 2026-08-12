using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Social_Media_Friend_Connections
    {
        public static void Main(string[] args)
        {
            SocialNetwork net1 = new SocialNetwork();

            net1.AddUser(1, "Amit", 22);
            net1.AddUser(2, "Rahul", 24);
            net1.AddUser(3, "Priya", 23);
            net1.AddUser(4, "Sneh", 25);

            net1.AddFriendConnection(1, 2);
            net1.AddFriendConnection(1, 3);
            net1.AddFriendConnection(2, 3);
            net1.AddFriendConnection(2, 4);

            Console.WriteLine("Displaying Friends of User 1 (Amit):");
            net1.DisplayFriends(1);

            Console.WriteLine("\nDisplaying Friends of User 2 (Rahul):");
            net1.DisplayFriends(2);

            Console.WriteLine("\nFinding Mutual Friends between User 1 (Amit) and User 2 (Rahul):");
            net1.FindMutualFriends(1, 2);

            Console.WriteLine("\nFriend Counts for All Users:");
            net1.CountFriendsForAll();

            Console.WriteLine("\nRemoving Friend Connection between 1 and 3:");
            net1.RemoveFriendConnection(1, 3);

            Console.WriteLine("\nFriends of User 1 (Amit) After Removal:");
            net1.DisplayFriends(1);
        }
    }

    class UserNode
    {
        public int userId;
        public string name;
        public int age;
        public List<int> friendIds;
        public UserNode next;

        public UserNode (int userId, string name, int age)
        {
            this.userId = userId;
            this.name = name;
            this.age = age;
            this.friendIds = new List<int>();
            this.next = null;
        }
    }

    class SocialNetwork
    {
        private UserNode head;

        public void AddUser(int id, string name, int age)
        {
            UserNode newNode = new UserNode(id, name, age);
            newNode.next = head;
            head = newNode;
        }

        public UserNode FindUserById(int id)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.userId == id) return temp;
                temp = temp.next;
            }
            return null;
        }

        public void AddFriendConnection(int u1, int u2)
        {
            UserNode user1 = FindUserById(u1);
            UserNode user2 = FindUserById(u2);
            if (user1 != null && user2 != null)
            {
                if (!user1.friendIds.Contains(u2)) user1.friendIds.Add(u2);
                if (!user2.friendIds.Contains(u1)) user2.friendIds.Add(u1);
            }
        }

        public void RemoveFriendConnection(int u1, int u2)
        {
            UserNode user1 = FindUserById(u1);
            UserNode user2 = FindUserById(u2);
            if (user1 != null && user2 != null)
            {
                user1.friendIds.Remove(u2);
                user2.friendIds.Remove(u1);
            }
        }

        public void FindMutualFriends(int u1, int u2)
        {
            UserNode user1 = FindUserById(u1);
            UserNode user2 = FindUserById(u2);
            if (user1 == null || user2 == null) return;

            Console.Write($"Mutual Friends between {user1.name} and {user2.name}: ");
            foreach (int fid in user1.friendIds)
            {
                if (user2.friendIds.Contains(fid))
                {
                    UserNode mutual = FindUserById(fid);
                    if (mutual != null)
                    {
                        Console.Write($"{mutual.name} ");
                    }
                }
            }
            Console.WriteLine();
        }

        public void DisplayFriends(int u1)
        {
            UserNode user = FindUserById(u1);
            if (user == null) return;

            Console.Write($"Friends of {user.name}: ");
            foreach (int fid in user.friendIds)
            {
                UserNode f = FindUserById(fid);
                if (f != null)
                {
                    Console.Write($"{f.name} ");
                }
            }
            Console.WriteLine();
        }

        public void CountFriendsForAll()
        {
            UserNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"User {temp.name} (ID: {temp.userId}) has {temp.friendIds.Count} friends.");
                temp = temp.next;
            }
            Console.Write("End of User Summary");
        }
    }
}
