namespace RpgClassesTests
{
    public class ArmorTest
    {
        [Fact]
        public void CreateArmor_ShouldReturnCorrectArmorName() 
        {
            //Arrange
            Armor testArmor = new Armor("Test Hat", 3, Armor.ArmorType.Cloth, Hero.Slots.Head);
            string expectedName = "Test Hat";
            //Act
            string actualName = testArmor.getItemName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectArmorRequiredLevel()
        {
            //Arrange
            Armor testArmor = new Armor("Test Hat", 3, Armor.ArmorType.Cloth, Hero.Slots.Head);
            int expectedReqLevel = 3;
            //Act
            int actualReqLevel = testArmor.getRequiredLevel();
            //Assert
            Assert.Equal(expectedReqLevel, actualReqLevel);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectArmorType()
        {
            //Arrange
            Armor testArmor = new Armor("Test Hat", 3, Armor.ArmorType.Cloth, Hero.Slots.Head);
            int expectedArmorType = 1;
            //Act
            int actualArmorType = (int)testArmor.armorType;
            //Assert
            Assert.Equal(expectedArmorType, actualArmorType);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectSlot()
        {
            //Arrange
            Armor testArmor = new Armor("Test Hat", 3, Armor.ArmorType.Cloth, Hero.Slots.Head);
            int expectedSlot = 2;
            //Act
            int actualSlot = (int)testArmor.getSlot();
            //Assert
            Assert.Equal(expectedSlot, actualSlot);
        }

    }
}