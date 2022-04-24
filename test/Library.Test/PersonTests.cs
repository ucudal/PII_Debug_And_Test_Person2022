using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void CorrectName() 
        {
            string expected = "John Doe";
            Person john = new Person("John Doe", "1.234.567-8");
            Assert.AreEqual(expected, john.Name);
        }
        [Test]
        public void CorrectId() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", "1.234.567-8");
            Assert.AreEqual(expected, john.ID);
        }
        [Test]
        public void NameNull() 
        {
            string expected = "John Doe";
            Person john = new Person(null, "1.234.567-8");
            Assert.AreEqual(expected, john.Name);
        }
        [Test]
        public void IdNull() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", null);
            Assert.AreEqual(expected, john.ID);
        }
        [Test]
        public void NameIncorrect() 
        {
            string expected = "John Doe";
            Person john = new Person("Jane Doe", "1.234.567-8");
            Assert.AreEqual(expected, john.Name);
        }
        [Test]
        public void IdIncorrect() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", "8.765.432-1");
            Assert.AreEqual(expected, john.ID);
        }
        [Test]
        public void NameEmpty() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("", "8.765.432-1");
            Assert.AreEqual(expected, john.Name);
        }
        [Test]
        public void IdEmpty() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", "");
            Assert.AreEqual(expected, john.ID);
        }
        [Test]
        public void IdLength() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", "1.234.5678-9");
            Assert.AreEqual(expected, john.ID);
        }
        [Test]
        public void IdCheckDigit() 
        {
            string expected = "1.234.567-8";
            Person john = new Person("John Doe", "1.234.567-0");
            Assert.AreEqual(expected, john.ID);
        }
    }
}