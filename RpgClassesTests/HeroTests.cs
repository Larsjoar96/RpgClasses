namespace RpgClassesTests
{
    public class HeroTest
    {
        [Fact]
        public void CreateMage_ShouldReturnCorrectName()
        {
            //Arrange
            string expectedName = "Joseph";
            //Act
            Mage testMage = new Mage(expectedName);
            string actualName = testMage.getName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void CreateRanger_ShouldReturnCorrectName()
        {
            //Arrange
            string expectedName = "Joseph";
            //Act
            Ranger testRanger = new Ranger(expectedName);
            string actualName = testRanger.getName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void CreateRogue_ShouldReturnCorrectName()
        {
            //Arrange
            string expectedName = "Joseph";
            //Act
            Rogue testRogue = new Rogue(expectedName);
            string actualName = testRogue.getName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void CreateWarrior_ShouldReturnCorrectName()
        {
            //Arrange
            string expectedName = "Joseph";
            //Act
            Warrior testWarrior = new Warrior(expectedName);
            string actualName = testWarrior.getName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        //[Fact]

    }
}