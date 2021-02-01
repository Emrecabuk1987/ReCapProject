using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {


        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
              new Car{Id=1,BrandId="Bmw",ColorId="Yeşil",ModelYear=2003,DailyPrice="100 TL",Description="3 Gün Üzeri Kiramalada %20 indirim"},
              new Car{Id=2,BrandId="Hyundai",ColorId="Kırmızı",ModelYear=2010,DailyPrice="80 TL",Description="5 Gün Üzeri Kiralamada %25 indirim"},
              new Car{Id=3,BrandId="Volkswagen",ColorId="Gri",ModelYear=2015,DailyPrice="120 TL",Description="4 Gün Üzeri Kiralamada %15 İndirim"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        

        public List<Car> GeyById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}
