using Xunit;
using Moq;

namespace CsWorkApp.Test
{
    public class WorkAppTest
    {
        [Fact]
        public void CalcSumTest()
        {
            //var calc = new Calc();

            //int result = calc.Sum(30, 40);

            //Assert.Equal(30 + 40, result);

            // Arrange
            var mock = new Mock<IDatabase>();
            mock.Setup(db => db.Employees())
                .Returns(EmployeesListTest());

            EmployeeWork work = new(mock.Object);

            // Action
            var result = work.Show();

            // Assert
            var assertResult = Assert.IsType<List<Employee>>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Employee>>(result);
            Assert.Equal(EmployeesListTest().Count, model.Count());
        }

        //[Fact]
        //public void MoqFrameworkReturnEmployeesTest()
        //{
        //    //var calc = new Calc();

        //    //int result = calc.Sum(30, 40);

        //    //Assert.Equal(30 + 40, result);

        //    // Arrange
        //    //var mock = new Mock<IDatabase>();
        //    //mock.Setup(db => db.Employees())
        //    //    .Returns(EmployeesListTest());

        //    //EmployeeWork work = new(mock.Object);

        //    //// Action
        //    //var result = work.Show();

        //    //// Assert
        //    //var assertResult = Assert.IsType<string>(result);
        //    //var model = Assert.IsAssignableFrom<IEnumerable<Employee>>(result);
        //    //Assert.Equal(EmployeesListTest().Count, model.Count());
        //    //}

        //}

        public List<Employee> EmployeesListTest()
        {
            return new()
            {
                new(){ Name = "Bobby", Age = 34 },
                new(){ Name = "Sammy", Age = 41 },
                new(){ Name = "Jimmy", Age = 27 },
                new(){ Name = "Lenny", Age = 19 },
                new(){ Name = "Poppy", Age = 25 },
            };
        }
    }
}
