using Microsoft.AspNetCore.Mvc;
using pantry_collabAPI.test.Models;

namespace pantry_collabAPI.test.Interfaces
{
    public interface IMyService
    {//1st : create a new interface named "IMyService" and define a GET method
        public Task<List<MyModel>> MyGetMethod(int id);

    }
}
