namespace RpgClassesTests
{
    public class MageTest
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
        public void CreateMage_ShouldReturnCorrectAttributes()
        {
            //Arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            //Act
            Mage testMage = new Mage("Joseph");
            int[] actualAttributes = new int[3] {testMage.getTotalAttributes().strength,
                                                 testMage.getTotalAttributes().dexterity,
                                                 testMage.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        [Fact]
        public void LevelMage_ShouldReturnTheCorrectLevelAfterLeveling()
        {
            //Arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //Act
            Mage testMage = new Mage("Joseph");
            testMage.LevelUp();
            int actualLevel = testMage.getLevel();
            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }
        [Fact]
        public void LevelMage_ShouldReturnTheCorrectAttributesAfterLeveling()
        {
            //Arrange
            int[] expectedCurrentAttributes = new int[3] { 1, 1, 8 };
            int[] expectedLevelAttributes = new int[3] { 1, 1, 5 };
            int[] expectedAttributes = new int[3] { expectedCurrentAttributes[0] + expectedLevelAttributes[0],
                                                    expectedCurrentAttributes[1] + expectedLevelAttributes[1],
                                                    expectedCurrentAttributes[2] + expectedLevelAttributes[2]};
            //Act
            Mage testMage = new Mage("Joseph");
            testMage.LevelUp();
            int[] actualAttributes = new int[3] {testMage.getTotalAttributes().strength,
                                                 testMage.getTotalAttributes().dexterity,
                                                 testMage.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
    }
}
