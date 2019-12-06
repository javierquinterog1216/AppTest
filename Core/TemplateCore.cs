using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Helper;
using DAL;

namespace Core
{
    public class TemplateCore
    {
        public ObjTemplateModel Get(int Id)
        {
            List<ObjTemplateModel> list = new List<ObjTemplateModel>();
            try
            {
                var item = DAL.TemplateDal.Get(Id).ToList<ObjTemplateModel>().FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<ObjTemplateModel> GetAll()
        {
            try
            {
                var list = DAL.TemplateDal.Get(Constant.AllItems).ToList<ObjTemplateModel>();
                return list;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(ObjTemplateModel model)
        {
            try
            {
                DAL.TemplateDal.Add(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Modify(ObjTemplateModel model)
        {
            try
            {
                DAL.TemplateDal.Modify(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(int Id)
        {
            try
            {
                DAL.TemplateDal.Delete(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
