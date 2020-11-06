using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Game;
namespace unit_test_simplegame
{
    [TestClass]
    public class UnitTest_simplegame
    {
        Class_SimpleGame Class_obj = new Class_SimpleGame();


        //coding to test the postive test case of shoot button

        [TestMethod]
        public void Test_shoot_on_Head_button()
        {
            int shoot_unit_data = Class_obj.shoot();
            Assert.AreEqual(1, shoot_unit_data);
        }

        //coding to test the postive test case of spin button

        [TestMethod]
        public void Test_spin_button()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreEqual(6, spin_unit_data);
        }
    }
}
