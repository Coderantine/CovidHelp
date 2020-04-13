using CovidHelp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CovidHelp.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedCities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                new Province { Id = 1, CreatedDate = DateTimeOffset.UtcNow, Name = "Երևան" },
                new Province { Id = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Արագածոտն" },
                new Province { Id = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Արարատ" },
                new Province { Id = 4, CreatedDate = DateTimeOffset.UtcNow, Name = "Արմավիր" },
                new Province { Id = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Արցախ" },
                new Province { Id = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Գեղարքունիք" },
                new Province { Id = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Կոտայք" },
                new Province { Id = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Լոռի" },
                new Province { Id = 9, CreatedDate = DateTimeOffset.UtcNow, Name = "Շիրակ" },
                new Province { Id = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Սյունիք" },
                new Province { Id = 11, CreatedDate = DateTimeOffset.UtcNow, Name = "Տավուշ" },
                new Province { Id = 12, CreatedDate = DateTimeOffset.UtcNow, Name = "Վայոց Ձոր" });


            modelBuilder.Entity<City>().HasData(
                // Արագածոտն
                new City { Id = 1, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Ապարան" },
                new City { Id = 2, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Արագած" },
                new City { Id = 3, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Արուճ" },
                new City { Id = 4, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Աշտարակ" },
                new City { Id = 5, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Կոշ" },
                new City { Id = 6, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Օշական" },
                new City { Id = 7, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Թալին" },
                new City { Id = 8, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Ուջան" },
                new City { Id = 9, ProvinceId = 2, CreatedDate = DateTimeOffset.UtcNow, Name = "Արարատ" },

                // Արարատ    
                new City { Id = 10, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Արտաշատ" },
                new City { Id = 11, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Այնթապ" },
                new City { Id = 12, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Գեղանիստ" },
                new City { Id = 13, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Մասիս" },
                new City { Id = 14, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Նոր Խարբերդ" },
                new City { Id = 15, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Վեդի" },
                new City { Id = 16, ProvinceId = 3, CreatedDate = DateTimeOffset.UtcNow, Name = "Արմավիր" },

                // Արմավիր
                new City { Id = 17, ProvinceId = 4, CreatedDate = DateTimeOffset.UtcNow, Name = "Էջմիածին" },
                new City { Id = 18, ProvinceId = 4, CreatedDate = DateTimeOffset.UtcNow, Name = "Մեծամոր" },

                // Արցախ
                new City { Id = 19, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Հադրութ" },
                new City { Id = 20, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Լաչին" },
                new City { Id = 21, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Մարտակերտ" },
                new City { Id = 22, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Մարտունի" },
                new City { Id = 23, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Շուշի" },
                new City { Id = 24, ProvinceId = 5, CreatedDate = DateTimeOffset.UtcNow, Name = "Ստեփանակերտ" },

                // Գեղարքունիք
                new City { Id = 25, ProvinceId = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Ճամբարակ" },
                new City { Id = 26, ProvinceId = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Գավառ" },
                new City { Id = 27, ProvinceId = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Մարտունի" },
                new City { Id = 28, ProvinceId = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Սևան" },
                new City { Id = 29, ProvinceId = 6, CreatedDate = DateTimeOffset.UtcNow, Name = "Վարդենիս" },

                // Կոտայք
                new City { Id = 30, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Աբովյան" },
                new City { Id = 31, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Աղվերան" },
                new City { Id = 32, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Արգել" },
                new City { Id = 33, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Առինջ" },
                new City { Id = 34, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Արզնի" },
                new City { Id = 35, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Բջնի" },
                new City { Id = 36, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Բյուրեղավան" },
                new City { Id = 37, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Չարենցավան" },
                new City { Id = 38, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Ձորաղբյուր" },
                new City { Id = 39, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Գառնի" },
                new City { Id = 40, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Գողթ" },
                new City { Id = 41, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Հրազդան" },
                new City { Id = 42, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Ջրվեժ" },
                new City { Id = 43, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Քանաքեռավան" },
                new City { Id = 44, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Քասախ" },
                new City { Id = 45, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Նոր Հաճըն" },
                new City { Id = 46, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Նուռնուս" },
                new City { Id = 47, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Պռոշյան" },
                new City { Id = 48, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Պտղնի" },
                new City { Id = 49, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Ծաղկաձոր" },
                new City { Id = 50, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Եղվարդ" },
                new City { Id = 51, ProvinceId = 7, CreatedDate = DateTimeOffset.UtcNow, Name = "Զովունի" },

                // Լոռի
                new City { Id = 52, ProvinceId = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Ալավերդի" },
                new City { Id = 53, ProvinceId = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Սպիտակ" },
                new City { Id = 54, ProvinceId = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Ստեփանավան" },
                new City { Id = 55, ProvinceId = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Տաշիր" },
                new City { Id = 56, ProvinceId = 8, CreatedDate = DateTimeOffset.UtcNow, Name = "Վանաձոր" },

                // Շիրակ
                new City { Id = 57, ProvinceId = 9, CreatedDate = DateTimeOffset.UtcNow, Name = "Արթիկ" },
                new City { Id = 58, ProvinceId = 9, CreatedDate = DateTimeOffset.UtcNow, Name = "Գյումրի" },
                new City { Id = 59, ProvinceId = 9, CreatedDate = DateTimeOffset.UtcNow, Name = "Մարալիկ" },

                // Սյունիք
                new City { Id = 60, ProvinceId = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Գորիս" },
                new City { Id = 61, ProvinceId = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Քաջարան" },
                new City { Id = 62, ProvinceId = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Կապան" },
                new City { Id = 63, ProvinceId = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Մեղրի" },
                new City { Id = 64, ProvinceId = 10, CreatedDate = DateTimeOffset.UtcNow, Name = "Սիսիան" },

                // Տավուշ
                new City { Id = 65, ProvinceId = 11, CreatedDate = DateTimeOffset.UtcNow, Name = "Բերդ" },
                new City { Id = 66, ProvinceId = 11, CreatedDate = DateTimeOffset.UtcNow, Name = "Դիլիջան" },
                new City { Id = 67, ProvinceId = 11, CreatedDate = DateTimeOffset.UtcNow, Name = "Իջևան" },
                new City { Id = 68, ProvinceId = 11, CreatedDate = DateTimeOffset.UtcNow, Name = "Նոյեմբերյան" },

                // Վայոց Ձոր
                new City { Id = 69, ProvinceId = 12, CreatedDate = DateTimeOffset.UtcNow, Name = "Ջերմուկ" },
                new City { Id = 70, ProvinceId = 12, CreatedDate = DateTimeOffset.UtcNow, Name = "Վայք" },
                new City { Id = 71, ProvinceId = 12, CreatedDate = DateTimeOffset.UtcNow, Name = "Եղեգնաձոր" });
        }
    }
}
