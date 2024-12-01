using System;
using ExerciseFive;

namespace TestExCinc
{
    public class UnitTest1
    {
        [Fact]
        public void Age0()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = 0;
            //Act
            int result= utils.ClassifyAge(age);
            //Assert
            Assert.Equal(0, result);

        }
        [Fact]
        public void Age119()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = 119;
            //Act
            int result = utils.ClassifyAge(age);
            //Assert
            Assert.Equal(2, result);

        }
        [Fact]
        public void Age1()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = 1;
            //Act
            int result = utils.ClassifyAge(age);
            //Assert
            Assert.Equal(0, result);

        }
        [Fact]
        public void AgeNegative()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = -1;
            //Act
            int result = utils.ClassifyAge(age);
            //Assert
            Assert.Equal(0, result);

        }
        [Fact]
        public void Age121()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = 121;
            //Act
            int result = utils.ClassifyAge(age);
            //Assert
            Assert.Equal(2, result);

        }
        [Fact]
        public void Age120()
        {
            //Arrange
            var utils = new PersonaHelper();
            int age = 120;
            //Act
            int result = utils.ClassifyAge(age);
            //Assert
            Assert.Equal(2, result);
            

        }
        [Fact]
        public void NameChar6()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "macarr";
            //Act
            bool result = utils.NameAnalyser(name).IsShort;
            bool result2 = utils.NameAnalyser(name).IsPalindrome;
            //Assert
            Assert.False(result);
            Assert.False(result2);

        }
        [Fact]
        public void NameChar4()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "maca";
            //Act
            bool result = utils.NameAnalyser(name).IsShort;
            bool result2 = utils.NameAnalyser(name).IsPalindrome;
            //Assert
            Assert.True(result);
            Assert.False(result2);

        }
        [Fact]
        public void NameChar5()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "macar";
            //Act
            bool result = utils.NameAnalyser(name).IsShort;
            bool result2 = utils.NameAnalyser(name).IsPalindrome;
            //Assert
            Assert.False(result);
            Assert.False(result2);

        }
        [Fact]
        public void NamePalin6()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "raraarar";
            //Act
            bool result = utils.NameAnalyser(name).IsPalindrome;
            bool result2 = utils.NameAnalyser(name).IsShort;
            //Assert
            Assert.True(result);
            Assert.False(result2);

        }
        [Fact]
        public void NamePalin5()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "taoat";
            //Act
            bool result = utils.NameAnalyser(name).IsPalindrome;
            bool result2 = utils.NameAnalyser(name).IsShort;
            //Assert
            Assert.True(result);
            Assert.False(result2);

        }
        [Fact]
        public void NamePalin4()
        {
            //Arrange
            var utils = new PersonaHelper();
            string name = "taat";
            //Act
            bool result = utils.NameAnalyser(name).IsPalindrome;
            bool result2 = utils.NameAnalyser(name).IsShort;
            //Assert
            Assert.True(result);
            Assert.True(result2);

        }
        [Fact]
        public void ColorInvalid()
        {
            //Arrange
            var utils = new PersonaHelper();
            string color = "";
            //Act
            int result = utils.VerifyColour(color);
            //Assert
            Assert.Equal(-1,result );
            

        }
        [Fact]
        public void ColorCalmant()
        {
            //Arrange
            var utils = new PersonaHelper();
            string color = "BLAU";
            //Act
            int result = utils.VerifyColour(color);
            //Assert
            Assert.Equal(0, result);


        }
        [Fact]
        public void ColorExclusiu()
        {
            //Arrange
            var utils = new PersonaHelper();
            string color = "RoSa";
            //Act
            int result = utils.VerifyColour(color);
            //Assert
            Assert.Equal(1, result);


        }
        [Fact]
        public void PersonalidadMati()
        {
            //Arrange
            var utils = new PersonaHelper();
            string per = "matí";
            //Act
            int result = utils.PersonalityTest(per);
            //Assert
            Assert.Equal(0, result);


        }
        [Fact]
        public void PersonalidadNit()
        {
            //Arrange
            var utils = new PersonaHelper();
            string per = "nit";
            //Act
            int result = utils.PersonalityTest(per);
            //Assert
            Assert.Equal(1, result);


        }
        [Fact]
        public void PersonalidadOtro()
        {
            //Arrange
            var utils = new PersonaHelper();
            string per = "Macarrones";
            //Act
            int result = utils.PersonalityTest(per);
            //Assert
            Assert.Equal(2, result);


        }

    }

}


