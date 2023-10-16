using _01_DataLogging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataLogging.Tests.UnitTests
{
    public class FileManagerUnitTests
    {
        [Fact]
        public void SaveToFile_Should_ReturnFalse_WhenFileNotCreated()
        {
            //Arrange
            IFileManager fileManager = new FileManager();
            string FilePath = "faketText";
            string content = ""

            //Act


            //Assert
        }
    }
}
