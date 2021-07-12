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
    public class KitapBusiness
    {
        MapperConfiguration config;
        Mapper mapper;
        KitapData kitapData;
        public KitapBusiness()
        {
            kitapData = new KitapData();
            config = new MapperConfiguration(q => q.CreateMap<Kitap, KitapListDTO>());
            mapper = new Mapper(config);
        }
        public void AddKitap(Kitap kitap)
        {
            kitapData.AddKitap(kitap);
        }

        public Kitap GetKitapById(int id)
        {
            var kitap = kitapData.GetKitapBtId(id);
            return kitap;
        }

        public void UpdateKitap(int id, Kitap kitap)
        {
            kitapData.UpdateKitap(id, kitap);
        }

        public void DeleteKitap(int id)
        {
            kitapData.DeleteKitap(id);
        }

        public List<Kitap> GetAllKitap()
        {
            var kitaplarListe = kitapData.GetAllKitap();
            return kitaplarListe;
        }

        public int GetKitapByName(string kitapAdi)
        {
            int id  =  kitapData.GetKitapByName(kitapAdi);
            return id;
        }

        public void StokArttir(int id ,int stokSayisi)
        {
            kitapData.StokArttir(id , stokSayisi);
        }
        public void StokAzalt(int id, int stokSayisi)
        {
            kitapData.StokAzalt(id, stokSayisi);
        }
        public List<KitapListDTO> GetAllKitapDTO()
        {
            var kitaplarListe = kitapData.GetAllKitap();         
            var kitaplarListeDTO = mapper.Map<List<Kitap>, List<KitapListDTO>>(kitaplarListe);
            return kitaplarListeDTO;
        }
        public List<KitapListDTO> GetMevcutAllKitapDTO()
        {
            
            var kitaplarListe = kitapData.GetAllKitap();
            List<Kitap> kitaplarDonusecek = new List<Kitap>();
            foreach(var kitap in kitaplarListe)
            {
                if(kitap.MusaitStok>0)
                {
                    kitaplarDonusecek.Add(kitap);
                }    
            }
            var kitaplarListeDTO = mapper.Map<List<Kitap>, List<KitapListDTO>>(kitaplarDonusecek);
            return kitaplarListeDTO;
        }

        public bool Kitapvarmi(int id)
        {
            return kitapData.KitapVarmi(id);
        }
        public void KitapKiralamaSonrasiStokAzalt(int id)
        {
            kitapData.KitapKiralamaSonrasiStokAzalt(id);
        }

        public void MusaitStokArttir(int kitapId)
        {
            kitapData.MusaitStokArttir(kitapId);
        }
    }
}
