using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeoFrendlyUrl.Models;

namespace SeoFrendlyUrl.Controllers
{
    public class NewsController :Controller
    {
        static List<News> model = new List<News>();
        public NewsController()
        {
            if (model.Count == 0)
            {
                model.AddRange(new News[]
         {
                new News(){
                Id = 1,
                Title = "Yeni yıldan ‘havalı’ beklentiler",
                Detail = @"İstanbul gibi Akdeniz ikliminin hâkim olduğu yerlerde en soğuk ay olan 
                        şubatta kar yağması kuvvetli bir ihtimal. Diğer zamanlarda da kısa süreli 
                        kar yağışları ve güneşli fakat hava kirliliği yüksek günler göreceğiz.",
                CreatedDate = DateTime.Now,
                Image="weather.jpg"
                },
                new News(){
                Id = 2,
                Title = "2018’in en popüler adresleri",
                Detail = @"Her yıl Türkiye’de seyahat edenlerin sayısı hızla artıyor. 2018’de de 
                           bu artışın devam etmesi bekleniyor. Artık yeni bir yıla giriyoruz. 2018’de nereye 
                           gideceğimize turizm acentaları ve biraz konunun uzmanı yazarlar karar veriyor.",
                CreatedDate = DateTime.Now,
                Image="place.jpg"
                },
                 new News(){
                Id = 3,
                Title = "Doğa insanları neden hep en mutlu ve en sağlıklı insanlardır?",
                Detail = @"Bilim adamları ağaçların yanında günde en az yarım saatini geçiren 
                         insanların öncelikle mental anlamda gelişim gösterdiğini ve bunun çok kısa sürede 
                         de fiziksel yansımalarının gerçekleştiğini söylüyor.",
                CreatedDate = DateTime.Now,
                Image="nature.jpg"
                },
                 new News(){
                Id = 4,
                Title = "Bilgisayarınızda virüs var mı? İşte anlamanın yolu",
                Detail = @"Son hastalığınız, sağlığınızla ilgili bazı sorunların 
                         işaretçisi olabilir. Benzer şekilde bilgisayarınıza bulaşan bir virüs, 
                         bir dizi işaret verebilir. Gördüğünüz tek bir işaret, virüsten kaynaklanmıyor 
                         olabilir ancak birkaç belirti, tehlike çanlarını duymanız gerektiği anlamına geliyor.",
                CreatedDate = DateTime.Now,
                Image="virus.jpg"
                }
         });
            }
        }
        public ActionResult Index()
        {
            return View(model);
        }
        public ActionResult Detail(string tag,string title ,int id)
        {
            News news = model.FirstOrDefault(x => x.Id == id);
            if (news != null)
            {
                return View(news);
            }
            return View("Error");
        }
    }
}