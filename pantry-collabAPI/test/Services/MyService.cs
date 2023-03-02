using Microsoft.AspNetCore.Mvc;
using pantry_collabAPI.Data;
using pantry_collabAPI.test.Interfaces;
using pantry_collabAPI.test.Models;

namespace pantry_collabAPI.test.Services
{
    public class MyService: IMyService //2nd: implement the IYOURSERVICE INterface
    {
        private readonly PantryDbContext _dbContext;
        public MyService(PantryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

     

        //3rd: use the HTTP client to make a GET request to the desired endpoint
        public async Task<List<MyModel>> MyGetMethod(int id)
        {
            var test = await _dbContext.MyModels.FindAsync(id);//endpoint
            if (test == null)
            
                throw new Exception("There is no test in the database to retrieve.");

            if (test.Name == null)
                throw new Exception("This test has no name");

            return new List<MyModel> { test};
        }
    }

   
}
