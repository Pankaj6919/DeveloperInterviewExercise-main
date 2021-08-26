using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ThirdPartyTools;

namespace FileData.Test
{
    [TestClass]
    public class FileDataTest
    {
        SetOfTasks tasks = new SetOfTasks();
        [TestMethod]
        public void TaskOne_Test()
        {
            //Arrange
            string[] args = new string[] { "-v", "C/test.txt" };
            //Act
            string actual = tasks.TaskOne(args);

            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TastSecondVersion_Test()
        {
            //Arrange
            string[] args = new string[] { "-v", "C/test.txt" };

            //Act
            string actual = tasks.TaskSecond(args);
            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TastSecondSize_Test()
        {
            //Arrange
            string[] args = new string[] { "-s", "C/test.txt" };

            //Act
            string actual = tasks.TaskSecond(args);
            //Assert
            Assert.IsNotNull(actual);
        }
    }
}
