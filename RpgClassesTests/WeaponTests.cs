namespace RpgClassesTests
{
    public class WeaponTest
    {
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectWeaponName() 
        {
            //Arrange
            Weapon testWeapon = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Hero.Slots.Weapon);
            string expectedName = "Fire Cane";
            //Act
            string actualName = testWeapon.getItemName();
            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectWeaponRequiredLevel()
        {
            //Arrange
            Weapon testWeapon = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Hero.Slots.Weapon);
            int expectedReqLevel = 3;
            //Act
            int actualReqLevel = testWeapon.getRequiredLevel();
            //Assert
            Assert.Equal(expectedReqLevel, actualReqLevel);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectWeaponType()
        {
            //Arrange
            Weapon testWeapon = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Hero.Slots.Weapon);
            int expectedWeaponType = 5;
            //Act
            int actualWeaponType = (int)testWeapon.weaponType;
            //Assert
            Assert.Equal(expectedWeaponType, actualWeaponType);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectSlot()
        {
            //Arrange
            Weapon testWeapon = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Hero.Slots.Weapon);
            int expectedSlot = 1;
            //Act
            int actualSlot = (int)testWeapon.getSlot();
            //Assert
            Assert.Equal(expectedSlot, actualSlot);
        }

    }
}