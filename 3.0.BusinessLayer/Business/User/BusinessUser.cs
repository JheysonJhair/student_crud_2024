using _0._0.DataTransferLayer.Objects;

namespace _3._0.BusinessLayer.Business.User
{
    public partial class BusinessUser
    {
        public DtoUser getByPk(string pk) 
        {
            return repoUser.getByPk(pk);
        }

        public List<DtoUser> getAll() 
        {
            return repoUser.getAll();
        }
        public int insertUser(DtoUser dtoUser)
        {
            return repoUser.insert(dtoUser);
        }
        public int deleteUser(string idUser)
        {
            return repoUser.delete(idUser);
        }
    }
}