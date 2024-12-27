using Moq;
using Xunit;
using System.Collections.Generic;
using TouristAgency.Models;
using TouristAgency.DataAccess.Repository.IRepository;
using TouristAgency.DataAccess.UOW;
using System.Linq.Expressions;

namespace TouristAgency.xUnit
{
    public class UnitTest_Clients
    {
        private Mock<IClientsRepository> _mockClientsRepo;
        private List<Clients> _mockClients;


        public UnitTest_Clients()
        {
            _mockClients = new List<Clients>
                {
                     new Clients
                        {
                            ClientId = 1,
                            EGN = 1231324,
                            ThreeNames = "John Doe Smith",
                            Country = "Bulgaria",
                            Gender = "Male",
                            BirthDate = new DateOnly(1990, 5, 15),
                            InsuranceNumber = new DateOnly(2023, 1, 1)
                        },

                     new Clients
                    {
                        ClientId = 2,
                        EGN = 1241,
                        ThreeNames = "Maria Petrova Ivanova",
                        Country = "Bulgaria",
                        Gender = "Female",
                        BirthDate = new DateOnly(1985, 7, 22),
                        InsuranceNumber = new DateOnly(2022, 6, 10)
                    },

                    new Clients
                    {
                        ClientId = 3,
                        EGN = 2342,
                        ThreeNames = "Georgi Dimitrov Alexandrov",
                        Country = "Bulgaria",
                        Gender = "Male",
                        BirthDate = new DateOnly(1992, 11, 30),
                        InsuranceNumber = new DateOnly(2024, 4, 5)
                    }

                };

            _mockClientsRepo = new Mock<IClientsRepository>();
        }

        [Fact]
        public async Task GetClientById_ReturnsCorrectClient()
        {
  
            var client = _mockClients.First(); 
            _mockClientsRepo.Setup(repo => repo.GetAsync(It.IsAny<Expression<Func<Clients, bool>>>(), true))
                            .ReturnsAsync(client); 

            var repository = _mockClientsRepo.Object;
            var result = await repository.GetAsync(c => c.ClientId == 1); 

   
            Assert.NotNull(result); 
            Assert.Equal("John Doe Smith", result.ThreeNames); 
            Assert.Equal(1, result.ClientId); 
        }

 
        [Fact]
        public async Task GetAllClients_ReturnsAllClients()
        {
   
            _mockClientsRepo.Setup(repo => repo.GetAllAsync(It.IsAny<Expression<Func<Clients, bool>>>(), true))
                            .ReturnsAsync(_mockClients);

            var repository = _mockClientsRepo.Object;

 
            var result = await repository.GetAllAsync(c => c.Country == "Bulgaria", true); 

            Assert.NotNull(result); 
            Assert.Equal(3, result.Count()); 
            Assert.Contains(result, c => c.ClientId == 1); 
            Assert.Contains(result, c => c.ClientId == 2); 
            Assert.Contains(result, c => c.ClientId == 3); 
        }


    }
}