using NUnit.Framework;
using Assignment3.Utility;
using Assignment3;

namespace Assignment3.Tests
{
    [TestFixture]
    public class LinkedListTest
    {
        [Test]
        public void Test_IsEmpty_InitiallyTrue()
        {
            SLL list = new SLL();
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void Test_AddFirst()
        {
            SLL list = new SLL();
            User user = new User(1, "Alice", "alice@example.com", "pass123");
            list.AddFirst(user);

            Assert.AreEqual(user, list.GetValue(0));
        }

        [Test]
        public void Test_AddLast()
        {
            SLL list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "pass123");
            User user2 = new User(1, "Bob", "alice@example.com", "pass123");

            list.AddLast(user1);
            list.AddLast(user2);

            Assert.AreEqual(user2, list.GetValue(1));
        }

        [Test]
        public void Test_AddAtIndex()
        {
            SLL list = new SLL();
            User u1 = new User(1, "Alice", "alice@example.com", "pass123");
            User u2 = new User(1, "Bob", "alice@example.com", "pass123");
            User u3 = new User(1, "Carol", "alice@example.com", "pass123");

            list.AddLast(u1);
            list.AddLast(u3);
            list.Add(u2, 1);

            Assert.AreEqual(u2, list.GetValue(1));
        }
        [Test]
        public void Test_ReplaceAtIndex()
        {
            SLL list = new SLL();
            User oldUser = new User(1, "Old", "old@example.com", "pass123");
            User newUser = new User(1, "New", "new@example.com", "pass123");

            list.AddLast(oldUser);
            list.Replace(newUser, 0);

            Assert.AreEqual(newUser, list.GetValue(0));
        }
        [Test]
        public void Test_RemoveFirst()
        {
            SLL list = new SLL();
            User u1 = new User(1, "A", "a@example.com", "pass123");
            User u2 = new User(1, "B", "b@example.com", "pass123");

            list.AddLast(u1);
            list.AddLast(u2);
            list.RemoveFirst();

            Assert.AreEqual(u2, list.GetValue(0));
        }



        [Test]
        public void Test_RemoveLast()
        {
            SLL list = new SLL();
            User u1 = new User(1, "A", "alice@example.com", "pass123");
            User u2 = new User(1, "B", "alice@example.com", "pass123");

            list.AddLast(u1);
            list.AddLast(u2);

            list.RemoveLast();

            Assert.AreEqual(u1, list.GetValue(0));
            Assert.AreEqual(1, list.Count());
        }

        [Test]
        public void Test_ContainsItem()
        {
            SLL list = new SLL();
            User user = new User(1, "Bob", "alice@example.com", "pass123");
            list.AddLast(user);

            Assert.IsTrue(list.Contains(user));
        }

        [Test]
        public void Test_RemoveAtIndex()
        {
            SLL list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "pass123");
            User user2 = new User(1, "Bob", "alice@example.com", "pass123");

            list.AddLast(user1);
            list.AddLast(user2);
            list.Remove(1);

            Assert.AreEqual(user1, list.GetValue(0));
            Assert.AreEqual(1, list.Count());

        }

        [Test]
        public void Test_ClearList()
        {
            SLL list = new SLL();
            list.AddLast(new User(1, "Alice", "alice@example.com", "pass123"));
            list.AddLast(new User(1, "Bob", "alice@example.com", "pass123"));
            list.Clear();

            Assert.IsTrue(list.IsEmpty());
            Assert.AreEqual(0, list.Count());
        }

        [Test]
        public void Test_ReverseList()
        {
            SLL list = new SLL();
            User u1 = new User(1, "Alice", "alice@example.com", "pass123");
            User u2 = new User(1, "Alice", "alice@example.com", "pass123");
            User u3 = new User(1, "Alice", "alice@example.com", "pass123");

            list.AddLast(u1);
            list.AddLast(u2);
            list.AddLast(u3);

            list.Reverse();

            Assert.AreEqual(u3, list.GetValue(0));
            Assert.AreEqual(u2, list.GetValue(1));
            Assert.AreEqual(u1, list.GetValue(2));
        }
    }
}