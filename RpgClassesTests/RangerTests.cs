namespace RpgClassesTests
{
    public class RangerTest
    {
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
        public void CreateRanger_ShouldReturnCorrectAttributes()
        {
            //Arrange
            int[] expectedAttributes = new int[3] { 1, 7, 1 };
            //Act
            Ranger testRanger = new Ranger("Joseph");
            int[] actualAttributes = new int[3] {testRanger.getTotalAttributes().strength,
                                                 testRanger.getTotalAttributes().dexterity,
                                                 testRanger.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        [Fact]
        public void LevelRanger_ShouldReturnTheCorrectLevelAfterLeveling()
        {
            //Arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //Act
            Ranger testRanger = new Ranger("Joseph");
            testRanger.LevelUp();
            int actualLevel = testRanger.getLevel();
            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }
        [Fact]
        public void LevelRanger_ShouldReturnTheCorrectAttributesAfterLeveling()
        {
            //Arrange
            int[] expectedCurrentAttributes = new int[3] { 1, 7, 1 };
            int[] expectedLevelAttributes = new int[3] { 1, 5, 1 };
            int[] expectedAttributes = new int[3] { expectedCurrentAttributes[0] + expectedLevelAttributes[0],
                                                    expectedCurrentAttributes[1] + expectedLevelAttributes[1],
                                                    expectedCurrentAttributes[2] + expectedLevelAttributes[2]};
            //Act
            Ranger testRanger = new Ranger("Joseph");
            testRanger.LevelUp();
            int[] actualAttributes = new int[3] {testRanger.getTotalAttributes().strength,
                                                 testRanger.getTotalAttributes().dexterity,
                                                 testRanger.getTotalAttributes().intellect};
            //Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
    }
}