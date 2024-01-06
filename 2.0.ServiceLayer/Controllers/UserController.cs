using _0._0.DataTransferLayer.Objects;
using _2._0.ServiceLayer.ServiceObject;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        BusinessUser _business = null;
        SoUser _so = null;

        public UserController() 
        {
            _business = new();
            _so = new();
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetByPk(string idUser)
        {
            _so.dtoUser = _business.getByPk(idUser);

            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoUser> GetAll() 
        {
            _so.listDtoUser = _business.getAll();

            return _so;
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult<SoUser> Insert([FromForm] DtoUser dtoUser)
        {
            int result = _business.insertUser(dtoUser);

            SoUser soResult = new SoUser();
            soResult.dtoUser = dtoUser; 
            soResult.listDtoUser = new List<DtoUser>();

            return soResult;
        }

        [HttpDelete]
        [Route("[action]")]
        public ActionResult<int> Delete(string idUser)
        {
            int result = _business.deleteUser(idUser);
            return result;
        }
    }
}