using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class DBObjects {
        public static void Initial(AppDBContent content) {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Shoes.Any()) {
                content.AddRange(
                  
                   
                    new Shoes {
                        name = "Nike Basketball shoes",
                        shortDesc = "D8 10.5-3",
                        longDesc = "BOY'S NIKE TEAM HUSTLE",
                        img = "/img/92886_179403_1.jpg",
                        price = 100,
                        isFavourite = true,
                        available = true,
                        Category = Categories["nike"]
                    },
                      new Shoes
                      {
                          name = "Adidas FYW 98",
                          shortDesc = "EG5196",
                          longDesc = "Comfortable, stylish",
                          img = "/img/adidas_FYW_98_EG5196.jpeg",
                          price = 87,
                          isFavourite = true,
                          available = true,
                          Category = Categories["adidas"]
                      },
                      new Shoes
                      {
                          name = "Adidas Hoops 2.0",
                          shortDesc = "EE7368",
                          longDesc = "Comfortable, stylish",
                          img = "/img/adidas-ee7368-hoops-2-0.jpg",
                          price = 65,
                          isFavourite = false,
                          available = true,
                          Category = Categories["adidas"]
                      },
                        new Shoes
                        {
                            name = "Adidas Handball Special",
                            shortDesc = "DB7633",
                            longDesc = "Comfortable, stylish",
                            img = "/img/Adidas-Handball-Spezial_DB7633.jpg",
                            price = 90,
                            isFavourite = true,
                            available = true,
                            Category = Categories["adidas"]
                        },
                        new Shoes
                        {
                            name = "Adidas Stan Smith",
                            shortDesc = "DB7632",
                            longDesc = "Comfortable, stylish",
                            img = "/img/adidas-originals-stan-smith.jpg",
                            price = 23,
                            isFavourite = true,
                            available = true,
                            Category = Categories["adidas"]
                        },
                         new Shoes
                         {
                             name = "Adidas Ozweego Black",
                             shortDesc = "DB7321",
                             longDesc = "Comfortable, stylish",
                             img = "/img/Adidas-Ozweego-Black.jpg",
                             price = 134,
                             isFavourite = false,
                             available = true,
                             Category = Categories["adidas"]
                         },
                          new Shoes
                          {
                              name = "Adidas ZX 750",
                              shortDesc = "DB7421",
                              longDesc = "Comfortable, stylish",
                              img = "/img/adidas-zx_750.jpg",
                              price = 150,
                              isFavourite = false,
                              available = true,
                              Category = Categories["adidas"]
                          },
                           new Shoes
                           {
                               name = "Nike Air Max 270",
                               shortDesc = "AE2312",
                               longDesc = "Comfortable, stylish",
                               img = "/img/nike_air_max_270_react_ci3866.jpg",
                               price = 64,
                               isFavourite = true,
                               available = true,
                               Category = Categories["nike"]
                           },
                             new Shoes
                             {
                                 name = "Nike Ebernon Low",
                                 shortDesc = "QA2232",
                                 longDesc = "Comfortable, stylish",
                                 img = "/img/nike_ebernon_low_QA2232.jpg",
                                 price = 123,
                                 isFavourite = true,
                                 available = true,
                                 Category = Categories["nike"]
                             },
                                new Shoes
                                {
                                    name = "Nike Path",
                                    shortDesc = "BQ4223",
                                    longDesc = "Comfortable, stylish",
                                    img = "/img/nike_path_BQ4223.jpg",
                                    price = 179,
                                    isFavourite = true,
                                    available = true,
                                    Category = Categories["nike"]
                                },
                                  new Shoes
                                  {
                                      name = "Nike SB Alleyoop",
                                      shortDesc = "WE23156",
                                      longDesc = "Comfortable, stylish",
                                      img = "/img/nike_sb_alleyoop.jpg",
                                      price = 239,
                                      isFavourite = false,
                                      available = true,
                                      Category = Categories["nike"]
                                  },
                                    new Shoes
                                    {
                                        name = "Nike SB Charge",
                                        shortDesc = "CD6279",
                                        longDesc = "Comfortable, stylish",
                                        img = "/img/nike_sb_charge_cd6279.jpg",
                                        price = 164,
                                        isFavourite = true,
                                        available = true,
                                        Category = Categories["nike"]
                                    },
                                     new Shoes
                                     {
                                         name = "Nike Tanjun",
                                         shortDesc = "812655",
                                         longDesc = "Comfortable, stylish",
                                         img = "/img/nike_tanjun_812655.jpg",
                                         price = 132,
                                         isFavourite = true,
                                         available = true,
                                         Category = Categories["nike"]
                                     },
                                       new Shoes
                                       {
                                           name = "Nike Air Jordan Retro High",
                                           shortDesc = "SD77083",
                                           longDesc = "Comfortable, stylish",
                                           img = "/img/nike-air-jordan-1-retro-high77083-5408026380101.jpg",
                                           price = 96,
                                           isFavourite = true,
                                           available = true,
                                           Category = Categories["nike"]
                                       },
                                         new Shoes
                                         {
                                             name = "Nike Superstar",
                                             shortDesc = "EG4958",
                                             longDesc = "Comfortable, stylish",
                                             img = "/img/superstar-eg4958.jpg",
                                             price = 96,
                                             isFavourite = true,
                                             available = true,
                                             Category = Categories["nike"]
                                         }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if(category == null) {
                    var list = new Category[] {
                        new Category { categoryName = "nike", desc = "stylish" },
                        new Category { categoryName = "adidas", desc = "modern" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
