using Equals.Fody;
using Fody;
using Xunit;

namespace ILGenerator.Test
{
    namespace GenerateEqualsTest
    {
        public class Equals��Identifier�����Ŏw�肳�ꂽ�v���p�e�B�ōs���邱��
        {
            private static readonly TestResult TestResult;

            static Equals��Identifier�����Ŏw�肳�ꂽ�v���p�e�B�ōs���邱��()
            {
                var weavingTask = new ModuleWeaver();
                TestResult = weavingTask.ExecuteTestRun("ILGenerator.dll", false);
            }

            [Fact]
            public void Identifier�����̎w�肳�ꂽ�v���p�e�B����Code�ł���()
            {
                var customer1 = TestResult.GetInstance("ILGenerator.Customer");
                customer1.Code = 1;
                var customer2 = TestResult.GetInstance("ILGenerator.Customer");
                customer2.Code = 1;
                Assert.True(customer1.Equals(customer2));
            }

            [Fact]
            public void Identifier�����̎w�肳�ꂽ�v���p�e�B����Id�ł���()
            {
                var employee1 = TestResult.GetInstance("ILGenerator.Employee");
                employee1.Id = 1;
                var employee2 = TestResult.GetInstance("ILGenerator.Employee");
                employee2.Id = 1;
                Assert.True(employee1.Equals(employee2));
            }
        }
    }
}
