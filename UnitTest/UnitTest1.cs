using System.Security.Cryptography;
using OPPPPP;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Encrypt_Decrypt_Should_Return_Original_Plaintext()
        {
            // Arrange
            string plaintext = "Hello, World!";
            Scitala scitala = new Scitala(5);

            // Act
            string ciphertext = scitala.Encrypt(plaintext);
            string decryptedText = scitala.Decrypt(ciphertext);

            // Assert
            Assert.AreEqual(plaintext, decryptedText);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetMessageLength_Should_Return_Length_Of_Plaintext()
        {
            // Arrange
            string plaintext = "Hello, World!";
            Scitala scitala = new Scitala(5);

            // Act
            scitala.Encrypt(plaintext);
            int messageLength = scitala.GetMessageLength();

            // Assert
            Assert.AreEqual(plaintext.Length, messageLength);
        }


    }
    [TestClass]
    public class UnitTests3
    {
        private const string TestDbPath = "C:\\Users\\kizar\\DBBBB.db";

        [TestMethod]
        public void CheckUserExists()
        {
            // Arrange
            string textBoxLog = "user1";
            string textBoxPass = "123";
            DBManager dbManager = new DBManager(TestDbPath);

            using (DBManager dbManager2 = new DBManager(TestDbPath))
            {
                dbManager2.AddUser(textBoxLog, textBoxPass);
                bool result = dbManager2.AuthUser(textBoxLog, textBoxPass);

                // Assert
                Assert.IsTrue(result, "User should exist in the database.");
            }
        }
    }
    [TestClass]
    public class UnitTests4
    {
        private const string TestDbPath = "C:\\Users\\kizar\\DBBBB.db";
        [TestMethod]
        public void TestUnregisteredUserDoesNotExistInDatabase()
        {
            // Arrange
            string username = "user22";
            string password = "113";
            DBManager dbManager = new DBManager(TestDbPath);

            // Act
            bool userExists = dbManager.AuthUser(username, password);

            // Assert
            Assert.IsFalse(userExists, "User should not exist in the database");
        }
    }
    ////[TestClass]
    ////public class UnitTest3
    ////{
    ////    [TestMethod]
    ////    public void TestMethod3()
    ////    {
    ////        bool FormMain = true;
    ////        string textBoxLog = "user1";
    ////        string textBoxPass = "123";
    ////        DBManager DBmanager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
    ////        Assert.AreEqual(FormMain, DBmanager.AuthUser(textBoxLog, textBoxPass));
    ////    }
    ////}

    ////[TestClass]
    ////public class UnitTest4
    ////{
    ////    [TestMethod]
    ////    public void TestMethod4()
    ////    {
    ////        bool Auth = false;
    ////        string AuthLogin = "user1234";
    ////        string AuthPwd = "12341235";
    ////        DBManager DBmanager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
    ////        Assert.AreEqual(Auth, DBmanager.AuthUser(AuthLogin, AuthPwd));
    ////    }
    ////}

}