using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestManager:ITestService
    {
        ITestDAL _test;

        public TestManager(ITestDAL test)
        {
            _test = test;
        }

        public List<Test> GetList()
        {
            return _test.GetListAll();
        }

        public void TAdd(Test t)
        {
            _test.Insert(t);
        }

        public void TDelete(Test t)
        {
            _test.Delete(t);
        }

        public Test TGetById(int id)
        {
            return _test.GetByID(id);
        }

        public void TUpdate(Test t)
        {
            _test.Update(t);
        }
    }
}
