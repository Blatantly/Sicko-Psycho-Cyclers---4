using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BikeStore.Models;
using Newtonsoft.Json;

namespace BikeStore.Controllers
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class ShoppingController : Controller
    {
        private readonly AdventureWorksLT2017gr1Context db;
        public ShoppingController(AdventureWorksLT2017gr1Context context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            List<Cart> cart = (List<Cart>)(HttpContext.Session.GetObjectFromJson<List<Cart>>("cart"));
            ViewBag.Session = cart;
            return View();
        }

        public IActionResult Order(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetObjectFromJson<List<Cart>>("cart") == null)
            {
                List<Cart> cart = new List<Cart>
                {
                    new Cart(db.Product.Find(id),1)
                };
                HttpContext.Session.SetObjectAsJson("cart", cart);
                ViewBag.Session = cart;
            }
            else
            {

                List<Cart> cart = (List<Cart>)(HttpContext.Session.GetObjectFromJson<List<Cart>>("cart"));
                int check = exist(id);
                if (check == -1)
                    cart.Add(new Cart(db.Product.Find(id), 1));
                else
                    cart[check].Quantity++;

                HttpContext.Session.SetObjectAsJson("cart", cart);
                ViewBag.Session = cart;
            }


            return View("Index");
        }

        private int exist(int? id)
        {
            List<Cart> cart = (List<Cart>)(HttpContext.Session.GetObjectFromJson<List<Cart>>("cart"));
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int check = exist(id);
            List<Cart> cart = (List<Cart>)(HttpContext.Session.GetObjectFromJson<List<Cart>>("cart"));
            cart.RemoveAt(check);
            HttpContext.Session.SetObjectAsJson("cart", cart);
            ViewBag.Session = cart;
            return View("Index");
        }



    }
}