using CalcOperations;

namespace TestProject2
{
    public class UnitTestCalcs
    {
        CalcOps co = new CalcOps();
        [Fact]
        public void TestAdd()
        {
            double vala = 6.2;
            double valb = 5;
            var sum = co.addition( vala, valb);
            Assert.True(sum.Equals(11.2),"Addition");
        }
        [Fact]
        public void TestSub()
        {

            double vala = 6.2;
            double valb = 2.1;
            var sum = co.subtraction(vala, valb);
            Assert.True(sum.Equals(4.1), "Subtraction");
        }
        [Fact]
        public void TestMult()
        {

            double vala = 3;
            double valb = 5;
            var sum = co.multiplication(vala, valb);
            Assert.True(sum.Equals(15), "Multiply");
        }
        [Fact]
        public void TestDiv()
        {

            double vala = 99;
            double valb = 3;
            var sum = co.division(vala, valb);
            Assert.True(sum.Equals(33), "Division");
        }
    }
}