using AutoMapper;
using Library_Automation.Data;
using Library_Automation.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Business
{
    public class CalisanBusiness
    {
        public int aktifId;
        MapperConfiguration config;
        Mapper mapper;
        CalisanData calisanData;
        public CalisanBusiness()
        {
            calisanData = new CalisanData();
            config = new MapperConfiguration(q => q.CreateMap<Calisan, CalisanListDTO>());
            mapper = new Mapper(config);
        }
        public List<CalisanListDTO> GetAllCalisanListDTO()
        {
            var calisanlar = calisanData.GetAllCalisan();
            var calisanlarDto = mapper.Map<List<Calisan>, List<CalisanListDTO>>(calisanlar);
            return calisanlarDto;
        }

        public void AddEmployee(Calisan calisan)
        {
            calisanData.AddEmployee(calisan);
        }

        public bool LoginEmployee(Calisan calisan)
        {
           var a = calisanData.LoginEmployee(calisan);
           return a ;
        }

        public void UpdateEmployee(int duzenlenecekId, Calisan calisan)
        {
            calisanData.UpdateEmployee(duzenlenecekId, calisan);
        }

        public void DeleteEmployee(int silenecekId)
        {
            calisanData.DeleteEmployee(silenecekId);
        }

        public int FindId(Calisan calisan)
        {
            return calisanData.FindId(calisan);
        }
    }
}
