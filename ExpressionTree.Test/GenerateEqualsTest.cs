using Xunit;

namespace ExpressionTree.Test
{
    namespace GenerateEqualsTest
    {
        public class Equals��Identifier�����Ŏw�肳�ꂽ�v���p�e�B�ōs���邱��
        {
            [Fact]
            public void Identifier�����̎w�肳�ꂽ�v���p�e�B����Code�ł���()
            {
                var customer1 = new Customer { Code = 1 };
                var customer2 = new Customer { Code = 1 };
                Assert.True(customer1.Equals(customer2));
            }

            [Fact]
            public void Identifier�����̎w�肳�ꂽ�v���p�e�B����Id�ł���()
            {
                var employee1 = new Employee { Id = 1 };
                var employee2 = new Employee { Id = 1 };
                Assert.True(employee1.Equals(employee2));
            }
        }
    }
}
