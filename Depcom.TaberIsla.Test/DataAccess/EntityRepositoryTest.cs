using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Depcom.TaberIsla.Repository.Base;
using System.Data.Entity;
using Depcom.TaberIsla.Domain;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using NSubstitute;
using System.Data.Entity.Infrastructure;
using Depcom.TaberIsla.DataAccess.Context;
using Moq;

namespace Depcom.TaberIsla.Test.DataAccess
{
    public class Item : Entity
    {
        public string Nombre { get; set; }

        public List<Item2> Items { get; set; }
    }

    public class Item2 : Entity
    {
        public string Nombre { get; set; }

        public DateTime Creacion { get; set; }
    }

    public class HelperDbContext : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
    }

    [TestClass]
    public class EntityRepositoryTest
    {
        private static List<Item> _mockData;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _mockData = new List<Item>
            {
                new Item { Id  = 1, Nombre = "MERB1", Items = new List<Item2>
                {
                    new Item2 {Id  = 1, Nombre = "ITEM1" }
                }},
                new Item { Id  = 2, Nombre = "TEST1" },
                new Item { Id  = 3, Nombre = "TEST2", Items = new List<Item2>
                {
                    new Item2 {Id  = 1, Nombre = "ITEM1" },
                    new Item2 {Id  = 2, Nombre = "ITEM2" },
                    new Item2 {Id  = 3, Nombre = "ITEM3" }
                }},
                new Item { Id  = 4, Nombre = "TEST3" }
            };
        }

        [TestMethod]
        public void CuandoObtengoTodosLosItems()
        {
            //Arrange
            IList<Item> resultFromRepository;
            var dbSet = Substitute.For<DbSet<Item>, IQueryable<Item>, IDbAsyncEnumerable<Item>>().SetupData(_mockData);
            var dbContext = Substitute.For<HelperDbContext>();
            dbContext.Set<Item>().Returns(dbSet);

            var repository = new Repository<Item>(dbContext);
            //Act
            resultFromRepository = repository.Get();
            //Assert
            Assert.IsNotNull(resultFromRepository);
            Assert.AreEqual(4, resultFromRepository.Count);
        }

        [TestMethod]
        public void CuandoObtengoTodosLosItems2()
        {
            //Arrange
            IList<Item> resultFromRepository;
            var dbSet = new Mock<DbSet<Item>>().SetupData(_mockData);
            var dbContext = new Mock<HelperDbContext>();
            dbContext.Setup(c => c.Set<Item>()).Returns(dbSet.Object);

            var repository = new Repository<Item>(dbContext.Object);
            //Act
            resultFromRepository = repository.Get();
            //Assert
            Assert.IsNotNull(resultFromRepository);
            Assert.AreEqual(4, resultFromRepository.Count);
        }

        [TestMethod]
        public void CuandoObtengoLosItemsConNombreMERB()
        {
            //Arrange
            string nombre = "MERB";
            IList<Item> resultFromRepository;

            var dbSet = new Mock<DbSet<Item>>().SetupData(_mockData);
            var dbContext = new Mock<HelperDbContext>();
            dbContext.Setup(c => c.Set<Item>()).Returns(dbSet.Object);

            var repository = new Repository<Item>(dbContext.Object);
            //Act
            resultFromRepository = repository.Get(i => i.Nombre.Contains(nombre));
            //Assert
            Assert.IsNotNull(resultFromRepository);
            Assert.AreEqual(1, resultFromRepository.Count);
        }

        [TestMethod]
        public void CuandoObtengoTodosLosItemsOrdenasAlfabeticamenteDesc()
        {
            //Arrange
            IList<Item> resultFromRepository;
            var dbSet = new Mock<DbSet<Item>>().SetupData(_mockData);
            var dbContext = new Mock<HelperDbContext>();
            dbContext.Setup(c => c.Set<Item>()).Returns(dbSet.Object);

            var repository = new Repository<Item>(dbContext.Object);
            //Act
            resultFromRepository = repository.Get(orderBy: o => o.OrderByDescending(i => i.Nombre));
            //Assert
            Assert.IsNotNull(resultFromRepository);
            Assert.AreEqual(4, resultFromRepository.Count);
            Assert.AreEqual(resultFromRepository[0].Id, 4);
            Assert.AreEqual(resultFromRepository[3].Id, 1);
        }

        [TestMethod]
        public void CuandoObtengoLosItemsConId3YIncluirItems()
        {
            //Arrange
            int id = 3;
            IList<Item> resultFromRepository;

            var dbSet = new Mock<DbSet<Item>>().SetupData(_mockData);
            var dbContext = new Mock<HelperDbContext>();
            dbContext.Setup(c => c.Set<Item>()).Returns(dbSet.Object);

            var repository = new Repository<Item>(dbContext.Object);
            //Act
            resultFromRepository = repository.Get(i => i.Id == id, includes: o => o.Items);
            //Assert
            Assert.IsNotNull(resultFromRepository);
            Assert.AreEqual(1, resultFromRepository.Count);
            Assert.IsNotNull(resultFromRepository[0].Items);
        }
    }
}
