namespace RpgClassesTests
{
    public class WarriorTest
    {
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
        [Fact]
        public void CreateWarrior_ShouldReturnCorrectAttributes()
        {
            //Arrange
            int[] expectedAttributes = new int[3] { 5, 2, 1 };
            //Act
            Warrior testWarrior = new Warrior("Joseph");
            int[] actualAttributes = new int[3] {testWarrior.getTotalAttributes().strength,
                                                 testWarrior.getTotalAttributes().dexterity,
                                                 testWarrior.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        [Fact]
        public void LevelWarrior_ShouldReturnTheCorrectLevelAfterLeveling()
        {
            //Arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //Act
            Warrior testWarrior = new Warrior("Joseph");
            testWarrior.LevelUp();
            int actualLevel = testWarrior.getLevel();
            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }
        [Fact]
        public void LevelWarrior_ShouldReturnTheCorrectAttributesAfterLeveling()
        {
            //Arrange
            int[] expectedCurrentAttributes = new int[3] { 5, 2, 1 };
            int[] expectedLevelAttributes = new int[3] { 3, 2, 1 };
            int[] expectedAttributes = new int[3] { expectedCurrentAttributes[0] + expectedLevelAttributes[0],
                                                    expectedCurrentAttributes[1] + expectedLevelAttributes[1],
                                                    expectedCurrentAttributes[2] + expectedLevelAttributes[2]};
            //Act
            Warrior testWarrior = new Warrior("Joseph");
            testWarrior.LevelUp();
            int[] actualAttributes = new int[3] {testWarrior.getTotalAttributes().strength,
                                                 testWarrior.getTotalAttributes().dexterity,
                                                 testWarrior.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }

    }
}