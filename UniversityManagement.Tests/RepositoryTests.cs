using UniversityManagement.Patterns.Repository;
using Xunit;

namespace UniversityManagement.Tests;

public class RepositoryTests
{
    [Fact]
    public void Repository_Should_Add_Item()
    {
        var repository =
            new GenericRepository<string>();

        repository.Add("Test");

        Assert.Single(repository.GetAll());
    }

    [Fact]
    public void Repository_Should_Delete_Item()
    {
        var repository =
            new GenericRepository<string>();

        repository.Add("Item");

        repository.Delete(1);

        Assert.Empty(repository.GetAll());
    }

}