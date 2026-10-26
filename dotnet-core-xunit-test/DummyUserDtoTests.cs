using System;
using dotnet_core_xunit.Dtos;
using Xunit;

namespace dotnet_core_xunit_test
{
    /// <summary>
    /// Standalone dummy tests (no fixtures, independent of UserControllerTest) so Test
    /// Intelligence has a second test file with its own call-graph chain (-> Dtos/UserDto.cs).
    /// All of these are expected to pass.
    /// </summary>
    public class DummyUserDtoTests
    {
        [Fact]
        public void NewUser_HasDefaultValues_Test()
        {
            var user = new UserDto.User();

            Assert.Equal(0, user.Id);
            Assert.Null(user.Email);
            Assert.False(user.Status);
        }

        [Fact]
        public void User_SetProperties_AreReadBack_Test()
        {
            var created = new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            var user = new UserDto.User
            {
                Id = 42,
                Email = "dummy@example.com",
                FullName = "Dummy User",
                CreateDate = created,
                Status = true
            };

            Assert.Equal(42, user.Id);
            Assert.Equal("dummy@example.com", user.Email);
            Assert.Equal("Dummy User", user.FullName);
            Assert.Equal(created, user.CreateDate);
            Assert.True(user.Status);
        }

        [Fact]
        public void TwoUsers_AreIndependentInstances_Test()
        {
            var a = new UserDto.User { Id = 1, Email = "a@example.com" };
            var b = new UserDto.User { Id = 2, Email = "b@example.com" };

            Assert.NotSame(a, b);
            Assert.NotEqual(a.Id, b.Id);
            Assert.NotEqual(a.Email, b.Email);
        }
    }
}
