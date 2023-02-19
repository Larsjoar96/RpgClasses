namespace RpgClassesTests
{
    public class RogueTest
    {
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
        public void CreateRogue_ShouldReturnCorrectAttributes()
        {
            //Arrange
            int[] expectedAttributes = new int[3] { 2, 6, 1 };
            //Act
            Rogue testRogue = new Rogue("Joseph");
            int[] actualAttributes = new int[3] {testRogue.getTotalAttributes().strength,
                                                 testRogue.getTotalAttributes().dexterity,
                                                 testRogue.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        [Fact]
        public void LevelRogue_ShouldReturnTheCorrectLevelAfterLeveling()
        {
            //Arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //Act
            Rogue testRogue = new Rogue("Joseph");
            testRogue.LevelUp();
            int actualLevel = testRogue.getLevel();
            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }
        [Fact]
        public void LevelRogue_ShouldReturnTheCorrectAttributesAfterLeveling()
        {
            //Arrange
            int[] expectedCurrentAttributes = new int[3] { 2, 6, 1 };
            int[] expectedLevelAttributes = new int[3] { 1, 4, 1 };
            int[] expectedAttributes = new int[3] { expectedCurrentAttributes[0] + expectedLevelAttributes[0],
                                                    expectedCurrentAttributes[1] + expectedLevelAttributes[1],
                                                    expectedCurrentAttributes[2] + expectedLevelAttributes[2]};
            //Act
            Rogue testRogue = new Rogue("Joseph");
            testRogue.LevelUp();
            int[] actualAttributes = new int[3] {testRogue.getTotalAttributes().strength,
                                                 testRogue.getTotalAttributes().dexterity,
                                                 testRogue.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

    }
}