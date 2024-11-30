using System.Formats.Asn1;
using RefraccioUtils;
namespace TestExerciciCuatre
{
    [TestClass]
    public class UnitTestExerciciCuatre
    {
        //CalculateArea
        [TestMethod]
        public void Area20()
        {
            //Arrange
            double width = 4;
            double height = 5;
            //Act
            double prova = width * height;
            double result = Utils.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(result, prova);
        }
        [TestMethod]
        public void AreaNegative()
        {
            //Arrange
            double width = -4;
            double height = 5;
            //Act
            double prova = width * height;
            double result = Utils.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(result, prova);
        }
        //CalculateCircum
        [TestMethod]
        public void Radius20()
        {
            //Arrange
            double radius = 20;
            //Act           
            double prova = 2 * Math.PI * radius;
            double result = Utils.CalculateCircum(radius);
            //Assert
            Assert.AreEqual(result, prova);
        }
        [TestMethod]    
        public void RadiusNegative()
        {
            //Arrange
            double radius = -20;
            //Act           
            double prova = 2 * Math.PI * radius;
            double result = Utils.CalculateCircum(radius);
            //Assert
            Assert.AreEqual(result, prova);
        }
        //GraterThanZero
        [TestMethod]
        public void IsNegative()
        {
            //Arrange
            double num = -20;
            //Act                       
            bool result = Utils.GraterThanZero(num);
            //Assert
            Assert.IsFalse(result);
        }
        public void IsPositive()
        {
            //Arrange
            double num = 20;
            //Act                       
            bool result = Utils.GraterThanZero(num);
            //Assert
            Assert.IsTrue(result);
        }
    }
}