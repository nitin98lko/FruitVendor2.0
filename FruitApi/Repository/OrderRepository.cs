using FruitUserApi.Data;
using FruitUserApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Repository
{
    public class OrderRepository
    {
        private readonly FruitVendorContext db ;
        public OrderRepository()
        {
            db = new FruitVendorContext();
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        internal bool CreateData(Order order)
        {
           List<Cart> cartList= db.Carts.ToList();
           
           foreach(Cart cart in cartList)
            {
                Order obj = new Order()
                {
                    amount = cart.amount,
                    date = order.date,
                    pm = order.pm,
                    placeAddress =order.placeAddress,
                    fId = cart.fId,
                    uId =cart.aId
                 };
                db.Orders.Add(obj);
                db.SaveChanges();            
            }

            foreach (Cart cart in cartList)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
            }
            return true;
        }
    }
}
