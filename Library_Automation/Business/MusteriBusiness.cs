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
    public class MusteriBusiness
    {
        MapperConfiguration config;
        Mapper mapper;
        MusteriData musteriData;
        public MusteriBusiness()
        {
            config = new MapperConfiguration(q => q.CreateMap<Musteri, MusteriDTO>());
            musteriData = new MusteriData();
            mapper = new Mapper(config);
        }
        public void AddMusteri(Musteri musteri)
        {
            musteriData.AddMusteri(musteri);
        }
        public List<Musteri> GetAllMusteri()
        {
            return musteriData.GetAllMusteri();
        }

        public Musteri GetById(int id)
        {
           return musteriData.GetById(id);
        }

        public void UpdateMusteri(int duzenlencekId, Musteri musteri)
        {
            musteriData.UpdateMusteri(duzenlencekId, musteri);
        }

        public void DeleteMusteri(int id)
        {
            musteriData.DeleteMusteri(id);
        }
        public List<MusteriDTO> GetAllMusteriDTO()
        {
            var musteriler = musteriData.GetAllMusteri();
            var musterilerDTO = mapper.Map<List<Musteri>, List<MusteriDTO>>(musteriler);
            return musterilerDTO;
        }

        public void MusteriCezaVer(int musteriId)
        {
            musteriData.MusteriCezaVer(musteriId);
        }

        public bool MusteriCezalimi(int id)
        {
            return musteriData.MusteriCezalimi(id);
        }
    }
}
