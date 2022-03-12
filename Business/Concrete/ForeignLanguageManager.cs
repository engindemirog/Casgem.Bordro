using Business.Abstract;
using Business.Requests;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignLanguageManager : IForeignLanguageService
    {
        IForeignLanguageDal _foreignLanguageDal;

        public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal)
        {
            _foreignLanguageDal = foreignLanguageDal;
        }

        public void Add(CreateForeignLanguageRequest createForeignLanguageRequest)
        {
            _foreignLanguageDal.Add(new ForeignLanguage { Name = createForeignLanguageRequest.Name});
        }
    }
}
