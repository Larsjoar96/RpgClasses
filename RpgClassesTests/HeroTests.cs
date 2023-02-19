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
        //[Fact]

    }
}